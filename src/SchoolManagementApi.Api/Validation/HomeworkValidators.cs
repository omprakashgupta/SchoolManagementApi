using FluentValidation;
using SchoolManagementApi.Api.DTOs.Homework;

namespace SchoolManagementApi.Api.Validation;

public sealed class HomeworkCreateDtoValidator : AbstractValidator<HomeworkCreateDto>
{
    public HomeworkCreateDtoValidator()
    {
        RuleFor(x => x.ClassId).NotEmpty();
        RuleFor(x => x.Title).NotEmpty().MaximumLength(200);
        RuleFor(x => x.DueDate).NotEmpty();
        RuleFor(x => x.Status).NotEmpty().MaximumLength(30);
    }
}

public sealed class HomeworkUpdateDtoValidator : AbstractValidator<HomeworkUpdateDto>
{
    public HomeworkUpdateDtoValidator()
    {
        RuleFor(x => x.ClassId).NotEmpty();
        RuleFor(x => x.Title).NotEmpty().MaximumLength(200);
        RuleFor(x => x.DueDate).NotEmpty();
        RuleFor(x => x.Status).NotEmpty().MaximumLength(30);
    }
}
