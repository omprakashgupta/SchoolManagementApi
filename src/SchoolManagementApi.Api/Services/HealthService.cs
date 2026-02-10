using AutoMapper;
using SchoolManagementApi.Api.DTOs.Health;
using SchoolManagementApi.Api.Entities;
using SchoolManagementApi.Api.Repositories;

namespace SchoolManagementApi.Api.Services;

public interface IHealthService : ICrudService<HealthDto, HealthCreateDto, HealthUpdateDto>
{
}

public sealed class HealthService : CrudServiceBase<HealthRecord, HealthDto, HealthCreateDto, HealthUpdateDto>, IHealthService
{
    public HealthService(IHealthRepository repository, IMapper mapper, IInputSanitizer sanitizer)
        : base(repository, mapper, sanitizer)
    {
    }
}
