using FluentValidation;
using SchoolManagementApi.Api.DTOs.Teachers;

namespace SchoolManagementApi.Api.Validation;

public sealed class TeacherCreateDtoValidator : AbstractValidator<TeacherCreateDto>
{
    public TeacherCreateDtoValidator()
    {
        RuleFor(x => x.FullName).NotEmpty().MaximumLength(150);
        RuleFor(x => x.Subject).NotEmpty().MaximumLength(100);
        RuleFor(x => x.Email).EmailAddress().MaximumLength(200);
    }
}

public sealed class TeacherUpdateDtoValidator : AbstractValidator<TeacherUpdateDto>
{
    public TeacherUpdateDtoValidator()
    {
        RuleFor(x => x.FullName).NotEmpty().MaximumLength(150);
        RuleFor(x => x.Subject).NotEmpty().MaximumLength(100);
        RuleFor(x => x.Email).EmailAddress().MaximumLength(200);
    }
}
