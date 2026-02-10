using AutoMapper;
using SchoolManagementApi.Api.DTOs.Fees;
using SchoolManagementApi.Api.Entities;
using SchoolManagementApi.Api.Repositories;

namespace SchoolManagementApi.Api.Services;

public interface IFeeService : ICrudService<FeeDto, FeeCreateDto, FeeUpdateDto>
{
}

public sealed class FeeService : CrudServiceBase<FeeRecord, FeeDto, FeeCreateDto, FeeUpdateDto>, IFeeService
{
    public FeeService(IFeeRepository repository, IMapper mapper, IInputSanitizer sanitizer)
        : base(repository, mapper, sanitizer)
    {
    }
}
