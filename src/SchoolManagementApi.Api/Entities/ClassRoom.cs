namespace SchoolManagementApi.Api.Entities;

public sealed class ClassRoom : IEntity
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Section { get; set; } = string.Empty;
    public string RoomNumber { get; set; } = string.Empty;
}
