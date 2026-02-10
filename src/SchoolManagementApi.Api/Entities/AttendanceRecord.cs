namespace SchoolManagementApi.Api.Entities;

public sealed class AttendanceRecord : IEntity
{
    public Guid Id { get; set; }
    public Guid StudentId { get; set; }
    public DateTime Date { get; set; }
    public string Status { get; set; } = string.Empty;
    public string Source { get; set; } = string.Empty;
}
