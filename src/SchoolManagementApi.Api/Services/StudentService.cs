using AutoMapper;
using SchoolManagementApi.Api.DTOs.Students;
using SchoolManagementApi.Api.Entities;
using SchoolManagementApi.Api.Repositories;

namespace SchoolManagementApi.Api.Services;

public interface IStudentService : ICrudService<StudentDto, StudentCreateDto, StudentUpdateDto>
{
}

public sealed class StudentService : CrudServiceBase<Student, StudentDto, StudentCreateDto, StudentUpdateDto>, IStudentService
{
    public StudentService(IStudentRepository repository, IMapper mapper, IInputSanitizer sanitizer)
        : base(repository, mapper, sanitizer)
    {
    }
}
