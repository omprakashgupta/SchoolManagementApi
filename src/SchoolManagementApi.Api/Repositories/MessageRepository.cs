using SchoolManagementApi.Api.Entities;
using SchoolManagementApi.Api.Infrastructure;

namespace SchoolManagementApi.Api.Repositories;

public interface IMessageRepository : ICrudRepository<Message>
{
}

public sealed class MessageRepository : DapperCrudRepository<Message>, IMessageRepository
{
    public MessageRepository(IDbConnectionFactory connectionFactory, IDapperExecutor executor)
        : base(connectionFactory, executor)
    {
    }

    protected override string TableName => "Messages";
    protected override string[] SearchColumns => new[] { "Content" };
}
