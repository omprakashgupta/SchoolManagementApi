using SchoolManagementApi.Api.Entities;
using SchoolManagementApi.Api.Infrastructure;

namespace SchoolManagementApi.Api.Repositories;

public interface IInventoryRepository : ICrudRepository<InventoryAsset>
{
}

public sealed class InventoryRepository : DapperCrudRepository<InventoryAsset>, IInventoryRepository
{
    public InventoryRepository(IDbConnectionFactory connectionFactory, IDapperExecutor executor)
        : base(connectionFactory, executor)
    {
    }

    protected override string TableName => "InventoryAssets";
    protected override string[] SearchColumns => new[] { "Name", "Category", "Location" };
}
