using SchoolManagementApi.Api.Entities;
using SchoolManagementApi.Api.Infrastructure;

namespace SchoolManagementApi.Api.Repositories;

public interface IHealthRepository : ICrudRepository<HealthRecord>
{
}

public sealed class HealthRepository : DapperCrudRepository<HealthRecord>, IHealthRepository
{
    public HealthRepository(IDbConnectionFactory connectionFactory, IDapperExecutor executor)
        : base(connectionFactory, executor)
    {
    }

    protected override string TableName => "HealthRecords";
    protected override string[] SearchColumns => new[] { "MedicalNotes", "Allergies" };
}
