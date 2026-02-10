namespace SchoolManagementApi.Api.Entities;

public sealed class LibraryBook : IEntity
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public string Isbn { get; set; } = string.Empty;
    public int AvailableCopies { get; set; }
}
