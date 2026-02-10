using SchoolManagementApi.Api.Entities;
using SchoolManagementApi.Api.Infrastructure;

namespace SchoolManagementApi.Api.Repositories;

public interface ILibraryRepository : ICrudRepository<LibraryBook>
{
}

public sealed class LibraryRepository : DapperCrudRepository<LibraryBook>, ILibraryRepository
{
    public LibraryRepository(IDbConnectionFactory connectionFactory, IDapperExecutor executor)
        : base(connectionFactory, executor)
    {
    }

    protected override string TableName => "LibraryBooks";
    protected override string[] SearchColumns => new[] { "Title", "Author", "Isbn" };
}
