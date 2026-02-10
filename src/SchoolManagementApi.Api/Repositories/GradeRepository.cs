using SchoolManagementApi.Api.Entities;
using SchoolManagementApi.Api.Infrastructure;

namespace SchoolManagementApi.Api.Repositories;

public interface IGradeRepository : ICrudRepository<GradeRecord>
{
}

public sealed class GradeRepository : DapperCrudRepository<GradeRecord>, IGradeRepository
{
    public GradeRepository(IDbConnectionFactory connectionFactory, IDapperExecutor executor)
        : base(connectionFactory, executor)
    {
    }

    protected override string TableName => "Grades";
    protected override string[] SearchColumns => new[] { "Subject", "Term" };
}
