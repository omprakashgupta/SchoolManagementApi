using System.Data;

namespace SchoolManagementApi.Api.Infrastructure;

public interface IDapperExecutor
{
    Task<IEnumerable<T>> QueryAsync<T>(IDbConnection connection, string sql, object? param = null);
    Task<T?> QuerySingleOrDefaultAsync<T>(IDbConnection connection, string sql, object? param = null);
    Task<int> ExecuteAsync(IDbConnection connection, string sql, object? param = null);
}
