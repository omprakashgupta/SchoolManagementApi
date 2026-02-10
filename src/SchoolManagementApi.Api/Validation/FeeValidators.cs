using FluentValidation;
using SchoolManagementApi.Api.DTOs.Fees;

namespace SchoolManagementApi.Api.Validation;

public sealed class FeeCreateDtoValidator : AbstractValidator<FeeCreateDto>
{
    public FeeCreateDtoValidator()
    {
        RuleFor(x => x.StudentId).NotEmpty();
        RuleFor(x => x.Amount).GreaterThan(0);
        RuleFor(x => x.DueDate).NotEmpty();
        RuleFor(x => x.Status).NotEmpty().MaximumLength(30);
    }
}

public sealed class FeeUpdateDtoValidator : AbstractValidator<FeeUpdateDto>
{
    public FeeUpdateDtoValidator()
    {
        RuleFor(x => x.StudentId).NotEmpty();
        RuleFor(x => x.Amount).GreaterThan(0);
        RuleFor(x => x.DueDate).NotEmpty();
        RuleFor(x => x.Status).NotEmpty().MaximumLength(30);
    }
}
