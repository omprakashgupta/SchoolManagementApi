namespace SchoolManagementApi.Api.Entities;

public sealed class TimetableEntry : IEntity
{
    public Guid Id { get; set; }
    public Guid ClassId { get; set; }
    public DayOfWeek DayOfWeek { get; set; }
    public TimeSpan StartTime { get; set; }
    public TimeSpan EndTime { get; set; }
    public string Subject { get; set; } = string.Empty;
    public Guid TeacherId { get; set; }
}
