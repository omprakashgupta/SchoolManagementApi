using AutoMapper;
using SchoolManagementApi.Api.DTOs.Teachers;
using SchoolManagementApi.Api.Entities;
using SchoolManagementApi.Api.Repositories;

namespace SchoolManagementApi.Api.Services;

public interface ITeacherService : ICrudService<TeacherDto, TeacherCreateDto, TeacherUpdateDto>
{
}

public sealed class TeacherService : CrudServiceBase<Teacher, TeacherDto, TeacherCreateDto, TeacherUpdateDto>, ITeacherService
{
    public TeacherService(ITeacherRepository repository, IMapper mapper, IInputSanitizer sanitizer)
        : base(repository, mapper, sanitizer)
    {
    }
}
