namespace SchoolManagementApi.Api.DTOs.Attendance;

public sealed class AttendanceDto
{
    public Guid Id { get; set; }
    public Guid StudentId { get; set; }
    public DateTime Date { get; set; }
    public string Status { get; set; } = string.Empty;
    public string Source { get; set; } = string.Empty;
}

public sealed class AttendanceCreateDto
{
    public Guid StudentId { get; set; }
    public DateTime Date { get; set; }
    public string Status { get; set; } = string.Empty;
    public string Source { get; set; } = string.Empty;
}

public sealed class AttendanceUpdateDto
{
    public Guid StudentId { get; set; }
    public DateTime Date { get; set; }
    public string Status { get; set; } = string.Empty;
    public string Source { get; set; } = string.Empty;
}

public sealed class BiometricAttendanceHookDto
{
    public string DeviceId { get; set; } = string.Empty;
    public Guid StudentId { get; set; }
    public DateTime Timestamp { get; set; }
    public string Status { get; set; } = string.Empty;
}
