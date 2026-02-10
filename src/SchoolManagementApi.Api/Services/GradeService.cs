using AutoMapper;
using SchoolManagementApi.Api.DTOs.Grades;
using SchoolManagementApi.Api.Entities;
using SchoolManagementApi.Api.Repositories;

namespace SchoolManagementApi.Api.Services;

public interface IGradeService : ICrudService<GradeDto, GradeCreateDto, GradeUpdateDto>
{
}

public sealed class GradeService : CrudServiceBase<GradeRecord, GradeDto, GradeCreateDto, GradeUpdateDto>, IGradeService
{
    public GradeService(IGradeRepository repository, IMapper mapper, IInputSanitizer sanitizer)
        : base(repository, mapper, sanitizer)
    {
    }
}
