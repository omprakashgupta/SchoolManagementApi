using AutoMapper;
using SchoolManagementApi.Api.DTOs.Transport;
using SchoolManagementApi.Api.Entities;
using SchoolManagementApi.Api.Repositories;

namespace SchoolManagementApi.Api.Services;

public interface ITransportService : ICrudService<TransportRouteDto, TransportRouteCreateDto, TransportRouteUpdateDto>
{
    Task<bool> SendAlertAsync(TransportAlertDto dto);
}

public sealed class TransportService : CrudServiceBase<TransportRoute, TransportRouteDto, TransportRouteCreateDto, TransportRouteUpdateDto>, ITransportService
{
    public TransportService(ITransportRepository repository, IMapper mapper, IInputSanitizer sanitizer)
        : base(repository, mapper, sanitizer)
    {
    }

    public Task<bool> SendAlertAsync(TransportAlertDto dto)
    {
        return Task.FromResult(!string.IsNullOrWhiteSpace(dto.Message));
    }
}
