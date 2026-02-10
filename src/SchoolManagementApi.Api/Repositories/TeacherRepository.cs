using SchoolManagementApi.Api.Entities;
using SchoolManagementApi.Api.Infrastructure;

namespace SchoolManagementApi.Api.Repositories;

public interface ITeacherRepository : ICrudRepository<Teacher>
{
}

public sealed class TeacherRepository : DapperCrudRepository<Teacher>, ITeacherRepository
{
    public TeacherRepository(IDbConnectionFactory connectionFactory, IDapperExecutor executor)
        : base(connectionFactory, executor)
    {
    }

    protected override string TableName => "Teachers";
    protected override string[] SearchColumns => new[] { "FullName", "Subject", "Email" };
}
