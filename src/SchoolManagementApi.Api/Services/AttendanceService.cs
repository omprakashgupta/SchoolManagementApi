using AutoMapper;
using SchoolManagementApi.Api.DTOs.Attendance;
using SchoolManagementApi.Api.Entities;
using SchoolManagementApi.Api.Repositories;

namespace SchoolManagementApi.Api.Services;

public interface IAttendanceService : ICrudService<AttendanceDto, AttendanceCreateDto, AttendanceUpdateDto>
{
    Task<Guid> RecordBiometricAsync(BiometricAttendanceHookDto dto);
}

public sealed class AttendanceService : CrudServiceBase<AttendanceRecord, AttendanceDto, AttendanceCreateDto, AttendanceUpdateDto>, IAttendanceService
{
    private readonly IAttendanceRepository _repository;

    public AttendanceService(IAttendanceRepository repository, IMapper mapper, IInputSanitizer sanitizer)
        : base(repository, mapper, sanitizer)
    {
        _repository = repository;
    }

    public Task<Guid> RecordBiometricAsync(BiometricAttendanceHookDto dto)
    {
        var record = new AttendanceRecord
        {
            Id = Guid.NewGuid(),
            StudentId = dto.StudentId,
            Date = dto.Timestamp,
            Status = dto.Status,
            Source = "Biometric"
        };

        return _repository.CreateAsync(record);
    }
}
