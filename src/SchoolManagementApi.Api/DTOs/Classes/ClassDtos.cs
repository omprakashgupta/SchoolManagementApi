namespace SchoolManagementApi.Api.DTOs.Classes;

public sealed class ClassDto
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Section { get; set; } = string.Empty;
    public string RoomNumber { get; set; } = string.Empty;
}

public sealed class ClassCreateDto
{
    public string Name { get; set; } = string.Empty;
    public string Section { get; set; } = string.Empty;
    public string RoomNumber { get; set; } = string.Empty;
}

public sealed class ClassUpdateDto
{
    public string Name { get; set; } = string.Empty;
    public string Section { get; set; } = string.Empty;
    public string RoomNumber { get; set; } = string.Empty;
}
