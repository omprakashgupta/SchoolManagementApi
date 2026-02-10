using Microsoft.Data.SqlClient;
using System.Data;

namespace SchoolManagementApi.Api.Infrastructure;

public sealed class SqlConnectionFactory : IDbConnectionFactory
{
    private readonly IConfiguration _configuration;

    public SqlConnectionFactory(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public IDbConnection CreateConnection()
    {
        var connectionString = _configuration.GetConnectionString("SchoolDb");
        return new SqlConnection(connectionString);
    }
}
