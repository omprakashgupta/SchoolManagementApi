using SchoolManagementApi.Api.Entities;
using SchoolManagementApi.Api.Infrastructure;

namespace SchoolManagementApi.Api.Repositories;

public interface IClassRepository : ICrudRepository<ClassRoom>
{
}

public sealed class ClassRepository : DapperCrudRepository<ClassRoom>, IClassRepository
{
    public ClassRepository(IDbConnectionFactory connectionFactory, IDapperExecutor executor)
        : base(connectionFactory, executor)
    {
    }

    protected override string TableName => "Classes";
    protected override string[] SearchColumns => new[] { "Name", "Section", "RoomNumber" };
}
