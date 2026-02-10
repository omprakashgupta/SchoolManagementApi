using FluentValidation;
using SchoolManagementApi.Api.DTOs.Timetable;

namespace SchoolManagementApi.Api.Validation;

public sealed class TimetableCreateDtoValidator : AbstractValidator<TimetableCreateDto>
{
    public TimetableCreateDtoValidator()
    {
        RuleFor(x => x.ClassId).NotEmpty();
        RuleFor(x => x.Subject).NotEmpty().MaximumLength(100);
        RuleFor(x => x.TeacherId).NotEmpty();
        RuleFor(x => x.EndTime).GreaterThan(x => x.StartTime);
    }
}

public sealed class TimetableUpdateDtoValidator : AbstractValidator<TimetableUpdateDto>
{
    public TimetableUpdateDtoValidator()
    {
        RuleFor(x => x.ClassId).NotEmpty();
        RuleFor(x => x.Subject).NotEmpty().MaximumLength(100);
        RuleFor(x => x.TeacherId).NotEmpty();
        RuleFor(x => x.EndTime).GreaterThan(x => x.StartTime);
    }
}
