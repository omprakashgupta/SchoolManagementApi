using SchoolManagementApi.Api.Entities;
using SchoolManagementApi.Api.Infrastructure;

namespace SchoolManagementApi.Api.Repositories;

public interface IExamRepository : ICrudRepository<ExamSchedule>
{
}

public sealed class ExamRepository : DapperCrudRepository<ExamSchedule>, IExamRepository
{
    public ExamRepository(IDbConnectionFactory connectionFactory, IDapperExecutor executor)
        : base(connectionFactory, executor)
    {
    }

    protected override string TableName => "Exams";
    protected override string[] SearchColumns => new[] { "ExamName" };
}
