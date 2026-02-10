using FluentValidation;
using SchoolManagementApi.Api.DTOs.Exams;

namespace SchoolManagementApi.Api.Validation;

public sealed class ExamCreateDtoValidator : AbstractValidator<ExamCreateDto>
{
    public ExamCreateDtoValidator()
    {
        RuleFor(x => x.ExamName).NotEmpty().MaximumLength(200);
        RuleFor(x => x.ClassId).NotEmpty();
        RuleFor(x => x.Date).NotEmpty();
        RuleFor(x => x.EndTime).GreaterThan(x => x.StartTime);
    }
}

public sealed class ExamUpdateDtoValidator : AbstractValidator<ExamUpdateDto>
{
    public ExamUpdateDtoValidator()
    {
        RuleFor(x => x.ExamName).NotEmpty().MaximumLength(200);
        RuleFor(x => x.ClassId).NotEmpty();
        RuleFor(x => x.Date).NotEmpty();
        RuleFor(x => x.EndTime).GreaterThan(x => x.StartTime);
    }
}
