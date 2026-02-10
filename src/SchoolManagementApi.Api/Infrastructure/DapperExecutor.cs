using Dapper;
using System.Data;

namespace SchoolManagementApi.Api.Infrastructure;

public sealed class DapperExecutor : IDapperExecutor
{
    public Task<IEnumerable<T>> QueryAsync<T>(IDbConnection connection, string sql, object? param = null)
    {
        return connection.QueryAsync<T>(sql, param);
    }

    public Task<T?> QuerySingleOrDefaultAsync<T>(IDbConnection connection, string sql, object? param = null)
    {
        return connection.QuerySingleOrDefaultAsync<T>(sql, param);
    }

    public Task<int> ExecuteAsync(IDbConnection connection, string sql, object? param = null)
    {
        return connection.ExecuteAsync(sql, param);
    }
}
