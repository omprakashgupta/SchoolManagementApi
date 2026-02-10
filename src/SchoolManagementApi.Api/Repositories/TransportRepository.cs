using SchoolManagementApi.Api.Entities;
using SchoolManagementApi.Api.Infrastructure;

namespace SchoolManagementApi.Api.Repositories;

public interface ITransportRepository : ICrudRepository<TransportRoute>
{
}

public sealed class TransportRepository : DapperCrudRepository<TransportRoute>, ITransportRepository
{
    public TransportRepository(IDbConnectionFactory connectionFactory, IDapperExecutor executor)
        : base(connectionFactory, executor)
    {
    }

    protected override string TableName => "TransportRoutes";
    protected override string[] SearchColumns => new[] { "RouteName", "BusNumber", "DriverName" };
}
