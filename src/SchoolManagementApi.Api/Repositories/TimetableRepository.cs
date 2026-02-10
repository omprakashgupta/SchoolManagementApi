using SchoolManagementApi.Api.Entities;
using SchoolManagementApi.Api.Infrastructure;

namespace SchoolManagementApi.Api.Repositories;

public interface ITimetableRepository : ICrudRepository<TimetableEntry>
{
}

public sealed class TimetableRepository : DapperCrudRepository<TimetableEntry>, ITimetableRepository
{
    public TimetableRepository(IDbConnectionFactory connectionFactory, IDapperExecutor executor)
        : base(connectionFactory, executor)
    {
    }

    protected override string TableName => "Timetables";
    protected override string[] SearchColumns => new[] { "Subject" };
}
