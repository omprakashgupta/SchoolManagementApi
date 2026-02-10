using SchoolManagementApi.Api.Entities;
using SchoolManagementApi.Api.Infrastructure;

namespace SchoolManagementApi.Api.Repositories;

public interface IStudentRepository : ICrudRepository<Student>
{
}

public sealed class StudentRepository : DapperCrudRepository<Student>, IStudentRepository
{
    public StudentRepository(IDbConnectionFactory connectionFactory, IDapperExecutor executor)
        : base(connectionFactory, executor)
    {
    }

    protected override string TableName => "Students";
    protected override string[] SearchColumns => new[] { "FirstName", "LastName", "Email" };
}
