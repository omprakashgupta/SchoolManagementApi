namespace SchoolManagementApi.Api.Entities;

public sealed class HealthRecord : IEntity
{
    public Guid Id { get; set; }
    public Guid StudentId { get; set; }
    public string MedicalNotes { get; set; } = string.Empty;
    public string Allergies { get; set; } = string.Empty;
    public string EmergencyContactName { get; set; } = string.Empty;
    public string EmergencyContactPhone { get; set; } = string.Empty;
    public DateTime LastUpdated { get; set; }
}
