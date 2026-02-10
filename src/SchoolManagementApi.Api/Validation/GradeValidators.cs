using FluentValidation;
using SchoolManagementApi.Api.DTOs.Grades;

namespace SchoolManagementApi.Api.Validation;

public sealed class GradeCreateDtoValidator : AbstractValidator<GradeCreateDto>
{
    public GradeCreateDtoValidator()
    {
        RuleFor(x => x.StudentId).NotEmpty();
        RuleFor(x => x.Subject).NotEmpty().MaximumLength(100);
        RuleFor(x => x.Score).InclusiveBetween(0, 100);
        RuleFor(x => x.Term).NotEmpty().MaximumLength(50);
    }
}

public sealed class GradeUpdateDtoValidator : AbstractValidator<GradeUpdateDto>
{
    public GradeUpdateDtoValidator()
    {
        RuleFor(x => x.StudentId).NotEmpty();
        RuleFor(x => x.Subject).NotEmpty().MaximumLength(100);
        RuleFor(x => x.Score).InclusiveBetween(0, 100);
        RuleFor(x => x.Term).NotEmpty().MaximumLength(50);
    }
}
