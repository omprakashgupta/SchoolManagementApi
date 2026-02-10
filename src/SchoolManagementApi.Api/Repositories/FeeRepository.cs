using SchoolManagementApi.Api.Entities;
using SchoolManagementApi.Api.Infrastructure;

namespace SchoolManagementApi.Api.Repositories;

public interface IFeeRepository : ICrudRepository<FeeRecord>
{
}

public sealed class FeeRepository : DapperCrudRepository<FeeRecord>, IFeeRepository
{
    public FeeRepository(IDbConnectionFactory connectionFactory, IDapperExecutor executor)
        : base(connectionFactory, executor)
    {
    }

    protected override string TableName => "Fees";
    protected override string[] SearchColumns => new[] { "Status" };
}
