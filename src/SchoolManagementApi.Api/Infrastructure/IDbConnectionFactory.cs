using System.Data;

namespace SchoolManagementApi.Api.Infrastructure;

public interface IDbConnectionFactory
{
    IDbConnection CreateConnection();
}
