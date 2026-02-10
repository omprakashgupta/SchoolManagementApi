namespace SchoolManagementApi.Api.DTOs.Analytics;

public sealed class StudentPerformanceTrendDto
{
    public Guid StudentId { get; set; }
    public string Metric { get; set; } = string.Empty;
    public decimal Value { get; set; }
}

public sealed class TeacherEffectivenessDto
{
    public Guid TeacherId { get; set; }
    public string Metric { get; set; } = string.Empty;
    public decimal Value { get; set; }
}

public sealed class ResourceUtilizationDto
{
    public string Resource { get; set; } = string.Empty;
    public decimal UtilizationRate { get; set; }
}
