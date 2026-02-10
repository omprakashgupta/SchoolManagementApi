using FluentValidation;
using SchoolManagementApi.Api.DTOs.Attendance;

namespace SchoolManagementApi.Api.Validation;

public sealed class AttendanceCreateDtoValidator : AbstractValidator<AttendanceCreateDto>
{
    public AttendanceCreateDtoValidator()
    {
        RuleFor(x => x.StudentId).NotEmpty();
        RuleFor(x => x.Date).NotEmpty();
        RuleFor(x => x.Status).NotEmpty().MaximumLength(20);
        RuleFor(x => x.Source).NotEmpty().MaximumLength(30);
    }
}

public sealed class AttendanceUpdateDtoValidator : AbstractValidator<AttendanceUpdateDto>
{
    public AttendanceUpdateDtoValidator()
    {
        RuleFor(x => x.StudentId).NotEmpty();
        RuleFor(x => x.Date).NotEmpty();
        RuleFor(x => x.Status).NotEmpty().MaximumLength(20);
        RuleFor(x => x.Source).NotEmpty().MaximumLength(30);
    }
}

public sealed class BiometricAttendanceHookDtoValidator : AbstractValidator<BiometricAttendanceHookDto>
{
    public BiometricAttendanceHookDtoValidator()
    {
        RuleFor(x => x.DeviceId).NotEmpty().MaximumLength(100);
        RuleFor(x => x.StudentId).NotEmpty();
        RuleFor(x => x.Timestamp).NotEmpty();
        RuleFor(x => x.Status).NotEmpty().MaximumLength(20);
    }
}
