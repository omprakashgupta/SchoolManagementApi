namespace SchoolManagementApi.Api.Entities;

public sealed class ExamSchedule : IEntity
{
    public Guid Id { get; set; }
    public string ExamName { get; set; } = string.Empty;
    public Guid ClassId { get; set; }
    public DateTime Date { get; set; }
    public TimeSpan StartTime { get; set; }
    public TimeSpan EndTime { get; set; }
}
