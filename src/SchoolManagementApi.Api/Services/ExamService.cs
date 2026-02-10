using AutoMapper;
using SchoolManagementApi.Api.DTOs.Exams;
using SchoolManagementApi.Api.Entities;
using SchoolManagementApi.Api.Repositories;

namespace SchoolManagementApi.Api.Services;

public interface IExamService : ICrudService<ExamDto, ExamCreateDto, ExamUpdateDto>
{
}

public sealed class ExamService : CrudServiceBase<ExamSchedule, ExamDto, ExamCreateDto, ExamUpdateDto>, IExamService
{
    public ExamService(IExamRepository repository, IMapper mapper, IInputSanitizer sanitizer)
        : base(repository, mapper, sanitizer)
    {
    }
}
