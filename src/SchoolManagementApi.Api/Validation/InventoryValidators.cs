using FluentValidation;
using SchoolManagementApi.Api.DTOs.Inventory;

namespace SchoolManagementApi.Api.Validation;

public sealed class InventoryCreateDtoValidator : AbstractValidator<InventoryCreateDto>
{
    public InventoryCreateDtoValidator()
    {
        RuleFor(x => x.Name).NotEmpty().MaximumLength(200);
        RuleFor(x => x.Category).NotEmpty().MaximumLength(100);
        RuleFor(x => x.Quantity).GreaterThanOrEqualTo(0);
        RuleFor(x => x.Location).NotEmpty().MaximumLength(100);
    }
}

public sealed class InventoryUpdateDtoValidator : AbstractValidator<InventoryUpdateDto>
{
    public InventoryUpdateDtoValidator()
    {
        RuleFor(x => x.Name).NotEmpty().MaximumLength(200);
        RuleFor(x => x.Category).NotEmpty().MaximumLength(100);
        RuleFor(x => x.Quantity).GreaterThanOrEqualTo(0);
        RuleFor(x => x.Location).NotEmpty().MaximumLength(100);
    }
}
