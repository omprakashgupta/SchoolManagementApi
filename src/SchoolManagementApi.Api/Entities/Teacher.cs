namespace SchoolManagementApi.Api.Entities;

public sealed class Teacher : IEntity
{
    public Guid Id { get; set; }
    public string FullName { get; set; } = string.Empty;
    public string Subject { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
}
