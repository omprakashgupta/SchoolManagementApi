using SchoolManagementApi.Api.Entities;
using SchoolManagementApi.Api.Infrastructure;

namespace SchoolManagementApi.Api.Repositories;

public interface IAttendanceRepository : ICrudRepository<AttendanceRecord>
{
}

public sealed class AttendanceRepository : DapperCrudRepository<AttendanceRecord>, IAttendanceRepository
{
    public AttendanceRepository(IDbConnectionFactory connectionFactory, IDapperExecutor executor)
        : base(connectionFactory, executor)
    {
    }

    protected override string TableName => "Attendance";
    protected override string[] SearchColumns => new[] { "Status", "Source" };
}
