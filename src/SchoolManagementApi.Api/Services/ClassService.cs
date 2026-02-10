using AutoMapper;
using SchoolManagementApi.Api.DTOs.Classes;
using SchoolManagementApi.Api.Entities;
using SchoolManagementApi.Api.Repositories;

namespace SchoolManagementApi.Api.Services;

public interface IClassService : ICrudService<ClassDto, ClassCreateDto, ClassUpdateDto>
{
}

public sealed class ClassService : CrudServiceBase<ClassRoom, ClassDto, ClassCreateDto, ClassUpdateDto>, IClassService
{
    public ClassService(IClassRepository repository, IMapper mapper, IInputSanitizer sanitizer)
        : base(repository, mapper, sanitizer)
    {
    }
}
