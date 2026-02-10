using Dapper;
using SchoolManagementApi.Api.DTOs.Common;
using SchoolManagementApi.Api.Entities;
using SchoolManagementApi.Api.Infrastructure;
using System.Reflection;

namespace SchoolManagementApi.Api.Repositories;

public abstract class DapperCrudRepository<T> : ICrudRepository<T> where T : class, IEntity
{
    private readonly IDbConnectionFactory _connectionFactory;
    private readonly IDapperExecutor _executor;

    protected DapperCrudRepository(IDbConnectionFactory connectionFactory, IDapperExecutor executor)
    {
        _connectionFactory = connectionFactory;
        _executor = executor;
    }

    protected abstract string TableName { get; }
    protected virtual string[] SearchColumns => Array.Empty<string>();

    public async Task<PagedResult<T>> GetAsync(QueryParameters query)
    {
        var normalized = query.Normalize();
        var parameters = new DynamicParameters();
        var whereClause = BuildSearchClause(normalized.Search, parameters);

        var countSql = $"SELECT COUNT(1) FROM [{TableName}] {whereClause}";
        var dataSql = $"SELECT * FROM [{TableName}] {whereClause} ORDER BY Id OFFSET @Offset ROWS FETCH NEXT @PageSize ROWS ONLY";

        parameters.Add("Offset", (normalized.PageNumber - 1) * normalized.PageSize);
        parameters.Add("PageSize", normalized.PageSize);

        using var connection = _connectionFactory.CreateConnection();
        var totalCount = await _executor.QuerySingleOrDefaultAsync<int>(connection, countSql, parameters);
        var items = await _executor.QueryAsync<T>(connection, dataSql, parameters);

        return new PagedResult<T>(items.ToList(), totalCount, normalized.PageNumber, normalized.PageSize);
    }

    public async Task<T?> GetByIdAsync(Guid id)
    {
        const string idFilter = "WHERE Id = @Id";
        var sql = $"SELECT * FROM [{TableName}] {idFilter}";

        using var connection = _connectionFactory.CreateConnection();
        return await _executor.QuerySingleOrDefaultAsync<T>(connection, sql, new { Id = id });
    }

    public async Task<Guid> CreateAsync(T entity)
    {
        if (entity.Id == Guid.Empty)
        {
            entity.Id = Guid.NewGuid();
        }

        var columns = GetColumns(excludeId: true);
        var columnList = string.Join(", ", columns.Select(column => $"[{column}]"));
        var parameterList = string.Join(", ", columns.Select(column => $"@{column}"));

        var sql = $"INSERT INTO [{TableName}] (Id, {columnList}) VALUES (@Id, {parameterList})";

        using var connection = _connectionFactory.CreateConnection();
        await _executor.ExecuteAsync(connection, sql, entity);

        return entity.Id;
    }

    public async Task<bool> UpdateAsync(T entity)
    {
        var columns = GetColumns(excludeId: true);
        var setClause = string.Join(", ", columns.Select(column => $"[{column}] = @{column}"));

        var sql = $"UPDATE [{TableName}] SET {setClause} WHERE Id = @Id";

        using var connection = _connectionFactory.CreateConnection();
        var affected = await _executor.ExecuteAsync(connection, sql, entity);

        return affected > 0;
    }

    public async Task<bool> DeleteAsync(Guid id)
    {
        var sql = $"DELETE FROM [{TableName}] WHERE Id = @Id";

        using var connection = _connectionFactory.CreateConnection();
        var affected = await _executor.ExecuteAsync(connection, sql, new { Id = id });

        return affected > 0;
    }

    private string BuildSearchClause(string? search, DynamicParameters parameters)
    {
        if (string.IsNullOrWhiteSpace(search) || SearchColumns.Length == 0)
        {
            return string.Empty;
        }

        var conditions = SearchColumns.Select(column => $"[{column}] LIKE @Search");
        parameters.Add("Search", $"%{search}%");

        return $"WHERE {string.Join(" OR ", conditions)}";
    }

    private static IEnumerable<string> GetColumns(bool excludeId)
    {
        var properties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance)
            .Where(property => property.CanRead && property.CanWrite);

        if (excludeId)
        {
            properties = properties.Where(property => !string.Equals(property.Name, "Id", StringComparison.OrdinalIgnoreCase));
        }

        return properties.Select(property => property.Name);
    }
}
