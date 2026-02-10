namespace SchoolManagementApi.Api.DTOs.Transport;

public sealed class TransportRouteDto
{
    public Guid Id { get; set; }
    public string RouteName { get; set; } = string.Empty;
    public string BusNumber { get; set; } = string.Empty;
    public string DriverName { get; set; } = string.Empty;
}

public sealed class TransportRouteCreateDto
{
    public string RouteName { get; set; } = string.Empty;
    public string BusNumber { get; set; } = string.Empty;
    public string DriverName { get; set; } = string.Empty;
}

public sealed class TransportRouteUpdateDto
{
    public string RouteName { get; set; } = string.Empty;
    public string BusNumber { get; set; } = string.Empty;
    public string DriverName { get; set; } = string.Empty;
}

public sealed class TransportAlertDto
{
    public Guid RouteId { get; set; }
    public string Message { get; set; } = string.Empty;
}
