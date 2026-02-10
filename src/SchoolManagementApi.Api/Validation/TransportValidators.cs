using FluentValidation;
using SchoolManagementApi.Api.DTOs.Transport;

namespace SchoolManagementApi.Api.Validation;

public sealed class TransportRouteCreateDtoValidator : AbstractValidator<TransportRouteCreateDto>
{
    public TransportRouteCreateDtoValidator()
    {
        RuleFor(x => x.RouteName).NotEmpty().MaximumLength(150);
        RuleFor(x => x.BusNumber).NotEmpty().MaximumLength(50);
        RuleFor(x => x.DriverName).NotEmpty().MaximumLength(150);
    }
}

public sealed class TransportRouteUpdateDtoValidator : AbstractValidator<TransportRouteUpdateDto>
{
    public TransportRouteUpdateDtoValidator()
    {
        RuleFor(x => x.RouteName).NotEmpty().MaximumLength(150);
        RuleFor(x => x.BusNumber).NotEmpty().MaximumLength(50);
        RuleFor(x => x.DriverName).NotEmpty().MaximumLength(150);
    }
}

public sealed class TransportAlertDtoValidator : AbstractValidator<TransportAlertDto>
{
    public TransportAlertDtoValidator()
    {
        RuleFor(x => x.RouteId).NotEmpty();
        RuleFor(x => x.Message).NotEmpty().MaximumLength(500);
    }
}
