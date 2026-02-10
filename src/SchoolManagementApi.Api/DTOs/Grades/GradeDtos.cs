namespace SchoolManagementApi.Api.DTOs.Grades;

public sealed class GradeDto
{
    public Guid Id { get; set; }
    public Guid StudentId { get; set; }
    public string Subject { get; set; } = string.Empty;
    public decimal Score { get; set; }
    public string Term { get; set; } = string.Empty;
}

public sealed class GradeCreateDto
{
    public Guid StudentId { get; set; }
    public string Subject { get; set; } = string.Empty;
    public decimal Score { get; set; }
    public string Term { get; set; } = string.Empty;
}

public sealed class GradeUpdateDto
{
    public Guid StudentId { get; set; }
    public string Subject { get; set; } = string.Empty;
    public decimal Score { get; set; }
    public string Term { get; set; } = string.Empty;
}
