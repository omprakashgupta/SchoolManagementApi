namespace SchoolManagementApi.Api.DTOs.Health;

public sealed class HealthDto
{
    public Guid Id { get; set; }
    public Guid StudentId { get; set; }
    public string MedicalNotes { get; set; } = string.Empty;
    public string Allergies { get; set; } = string.Empty;
    public string EmergencyContactName { get; set; } = string.Empty;
    public string EmergencyContactPhone { get; set; } = string.Empty;
    public DateTime LastUpdated { get; set; }
}

public sealed class HealthCreateDto
{
    public Guid StudentId { get; set; }
    public string MedicalNotes { get; set; } = string.Empty;
    public string Allergies { get; set; } = string.Empty;
    public string EmergencyContactName { get; set; } = string.Empty;
    public string EmergencyContactPhone { get; set; } = string.Empty;
    public DateTime LastUpdated { get; set; }
}

public sealed class HealthUpdateDto
{
    public Guid StudentId { get; set; }
    public string MedicalNotes { get; set; } = string.Empty;
    public string Allergies { get; set; } = string.Empty;
    public string EmergencyContactName { get; set; } = string.Empty;
    public string EmergencyContactPhone { get; set; } = string.Empty;
    public DateTime LastUpdated { get; set; }
}
