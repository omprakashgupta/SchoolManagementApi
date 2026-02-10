namespace SchoolManagementApi.Api.DTOs.Exams;

public sealed class ExamDto
{
    public Guid Id { get; set; }
    public string ExamName { get; set; } = string.Empty;
    public Guid ClassId { get; set; }
    public DateTime Date { get; set; }
    public TimeSpan StartTime { get; set; }
    public TimeSpan EndTime { get; set; }
}

public sealed class ExamCreateDto
{
    public string ExamName { get; set; } = string.Empty;
    public Guid ClassId { get; set; }
    public DateTime Date { get; set; }
    public TimeSpan StartTime { get; set; }
    public TimeSpan EndTime { get; set; }
}

public sealed class ExamUpdateDto
{
    public string ExamName { get; set; } = string.Empty;
    public Guid ClassId { get; set; }
    public DateTime Date { get; set; }
    public TimeSpan StartTime { get; set; }
    public TimeSpan EndTime { get; set; }
}
