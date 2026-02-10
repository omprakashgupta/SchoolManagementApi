using AutoMapper;
using SchoolManagementApi.Api.DTOs.Timetable;
using SchoolManagementApi.Api.Entities;
using SchoolManagementApi.Api.Repositories;

namespace SchoolManagementApi.Api.Services;

public interface ITimetableService : ICrudService<TimetableDto, TimetableCreateDto, TimetableUpdateDto>
{
}

public sealed class TimetableService : CrudServiceBase<TimetableEntry, TimetableDto, TimetableCreateDto, TimetableUpdateDto>, ITimetableService
{
    public TimetableService(ITimetableRepository repository, IMapper mapper, IInputSanitizer sanitizer)
        : base(repository, mapper, sanitizer)
    {
    }
}
