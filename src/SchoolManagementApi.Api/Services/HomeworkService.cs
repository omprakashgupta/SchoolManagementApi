using AutoMapper;
using SchoolManagementApi.Api.DTOs.Homework;
using SchoolManagementApi.Api.Entities;
using SchoolManagementApi.Api.Repositories;

namespace SchoolManagementApi.Api.Services;

public interface IHomeworkService : ICrudService<HomeworkDto, HomeworkCreateDto, HomeworkUpdateDto>
{
}

public sealed class HomeworkService : CrudServiceBase<HomeworkAssignment, HomeworkDto, HomeworkCreateDto, HomeworkUpdateDto>, IHomeworkService
{
    public HomeworkService(IHomeworkRepository repository, IMapper mapper, IInputSanitizer sanitizer)
        : base(repository, mapper, sanitizer)
    {
    }
}
