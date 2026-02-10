namespace SchoolManagementApi.Api.DTOs.Homework;

public sealed class HomeworkDto
{
    public Guid Id { get; set; }
    public Guid ClassId { get; set; }
    public string Title { get; set; } = string.Empty;
    public DateTime DueDate { get; set; }
    public string Status { get; set; } = string.Empty;
}

public sealed class HomeworkCreateDto
{
    public Guid ClassId { get; set; }
    public string Title { get; set; } = string.Empty;
    public DateTime DueDate { get; set; }
    public string Status { get; set; } = string.Empty;
}

public sealed class HomeworkUpdateDto
{
    public Guid ClassId { get; set; }
    public string Title { get; set; } = string.Empty;
    public DateTime DueDate { get; set; }
    public string Status { get; set; } = string.Empty;
}
