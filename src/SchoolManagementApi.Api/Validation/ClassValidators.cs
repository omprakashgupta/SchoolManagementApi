using FluentValidation;
using SchoolManagementApi.Api.DTOs.Classes;

namespace SchoolManagementApi.Api.Validation;

public sealed class ClassCreateDtoValidator : AbstractValidator<ClassCreateDto>
{
    public ClassCreateDtoValidator()
    {
        RuleFor(x => x.Name).NotEmpty().MaximumLength(100);
        RuleFor(x => x.Section).NotEmpty().MaximumLength(50);
        RuleFor(x => x.RoomNumber).NotEmpty().MaximumLength(20);
    }
}

public sealed class ClassUpdateDtoValidator : AbstractValidator<ClassUpdateDto>
{
    public ClassUpdateDtoValidator()
    {
        RuleFor(x => x.Name).NotEmpty().MaximumLength(100);
        RuleFor(x => x.Section).NotEmpty().MaximumLength(50);
        RuleFor(x => x.RoomNumber).NotEmpty().MaximumLength(20);
    }
}
