namespace SchoolManagementApi.Api.Entities;

public sealed class TransportRoute : IEntity
{
    public Guid Id { get; set; }
    public string RouteName { get; set; } = string.Empty;
    public string BusNumber { get; set; } = string.Empty;
    public string DriverName { get; set; } = string.Empty;
}
