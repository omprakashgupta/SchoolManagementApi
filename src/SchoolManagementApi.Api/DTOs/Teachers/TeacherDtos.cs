namespace SchoolManagementApi.Api.DTOs.Teachers;

public sealed class TeacherDto
{
    public Guid Id { get; set; }
    public string FullName { get; set; } = string.Empty;
    public string Subject { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
}

public sealed class TeacherCreateDto
{
    public string FullName { get; set; } = string.Empty;
    public string Subject { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
}

public sealed class TeacherUpdateDto
{
    public string FullName { get; set; } = string.Empty;
    public string Subject { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
}
