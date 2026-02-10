namespace SchoolManagementApi.Api.DTOs.Timetable;

public sealed class TimetableDto
{
    public Guid Id { get; set; }
    public Guid ClassId { get; set; }
    public DayOfWeek DayOfWeek { get; set; }
    public TimeSpan StartTime { get; set; }
    public TimeSpan EndTime { get; set; }
    public string Subject { get; set; } = string.Empty;
    public Guid TeacherId { get; set; }
}

public sealed class TimetableCreateDto
{
    public Guid ClassId { get; set; }
    public DayOfWeek DayOfWeek { get; set; }
    public TimeSpan StartTime { get; set; }
    public TimeSpan EndTime { get; set; }
    public string Subject { get; set; } = string.Empty;
    public Guid TeacherId { get; set; }
}

public sealed class TimetableUpdateDto
{
    public Guid ClassId { get; set; }
    public DayOfWeek DayOfWeek { get; set; }
    public TimeSpan StartTime { get; set; }
    public TimeSpan EndTime { get; set; }
    public string Subject { get; set; } = string.Empty;
    public Guid TeacherId { get; set; }
}
