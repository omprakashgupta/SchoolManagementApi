using SchoolManagementApi.Api.Entities;
using SchoolManagementApi.Api.Infrastructure;

namespace SchoolManagementApi.Api.Repositories;

public interface IAnnouncementRepository : ICrudRepository<Announcement>
{
}

public sealed class AnnouncementRepository : DapperCrudRepository<Announcement>, IAnnouncementRepository
{
    public AnnouncementRepository(IDbConnectionFactory connectionFactory, IDapperExecutor executor)
        : base(connectionFactory, executor)
    {
    }

    protected override string TableName => "Announcements";
    protected override string[] SearchColumns => new[] { "Title", "Content" };
}
