using FluentValidation;
using SchoolManagementApi.Api.DTOs.Students;

namespace SchoolManagementApi.Api.Validation;

public sealed class StudentCreateDtoValidator : AbstractValidator<StudentCreateDto>
{
    public StudentCreateDtoValidator()
    {
        RuleFor(x => x.FirstName).NotEmpty().MaximumLength(100);
        RuleFor(x => x.LastName).NotEmpty().MaximumLength(100);
        RuleFor(x => x.DateOfBirth).LessThan(DateTime.UtcNow.Date.AddDays(1));
        RuleFor(x => x.GradeLevel).NotEmpty().MaximumLength(20);
        RuleFor(x => x.Email).EmailAddress().MaximumLength(200);
        RuleFor(x => x.Phone).NotEmpty().MaximumLength(30);
    }
}

public sealed class StudentUpdateDtoValidator : AbstractValidator<StudentUpdateDto>
{
    public StudentUpdateDtoValidator()
    {
        RuleFor(x => x.FirstName).NotEmpty().MaximumLength(100);
        RuleFor(x => x.LastName).NotEmpty().MaximumLength(100);
        RuleFor(x => x.DateOfBirth).LessThan(DateTime.UtcNow.Date.AddDays(1));
        RuleFor(x => x.GradeLevel).NotEmpty().MaximumLength(20);
        RuleFor(x => x.Email).EmailAddress().MaximumLength(200);
        RuleFor(x => x.Phone).NotEmpty().MaximumLength(30);
    }
}
