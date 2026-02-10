namespace SchoolManagementApi.Api.DTOs.Library;

public sealed class LibraryBookDto
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public string Isbn { get; set; } = string.Empty;
    public int AvailableCopies { get; set; }
}

public sealed class LibraryBookCreateDto
{
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public string Isbn { get; set; } = string.Empty;
    public int AvailableCopies { get; set; }
}

public sealed class LibraryBookUpdateDto
{
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public string Isbn { get; set; } = string.Empty;
    public int AvailableCopies { get; set; }
}

public sealed class IssueBookDto
{
    public Guid StudentId { get; set; }
    public DateTime DueDate { get; set; }
}

public sealed class ReturnBookDto
{
    public DateTime ReturnedAt { get; set; }
}
