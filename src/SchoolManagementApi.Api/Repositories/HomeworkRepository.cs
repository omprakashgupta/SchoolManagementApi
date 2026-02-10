using SchoolManagementApi.Api.Entities;
using SchoolManagementApi.Api.Infrastructure;

namespace SchoolManagementApi.Api.Repositories;

public interface IHomeworkRepository : ICrudRepository<HomeworkAssignment>
{
}

public sealed class HomeworkRepository : DapperCrudRepository<HomeworkAssignment>, IHomeworkRepository
{
    public HomeworkRepository(IDbConnectionFactory connectionFactory, IDapperExecutor executor)
        : base(connectionFactory, executor)
    {
    }

    protected override string TableName => "Homework";
    protected override string[] SearchColumns => new[] { "Title", "Status" };
}
