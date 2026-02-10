using FluentValidation;
using SchoolManagementApi.Api.DTOs.Health;

namespace SchoolManagementApi.Api.Validation;

public sealed class HealthCreateDtoValidator : AbstractValidator<HealthCreateDto>
{
    public HealthCreateDtoValidator()
    {
        RuleFor(x => x.StudentId).NotEmpty();
        RuleFor(x => x.MedicalNotes).NotEmpty().MaximumLength(2000);
        RuleFor(x => x.Allergies).MaximumLength(500);
        RuleFor(x => x.EmergencyContactName).NotEmpty().MaximumLength(150);
        RuleFor(x => x.EmergencyContactPhone).NotEmpty().MaximumLength(30);
        RuleFor(x => x.LastUpdated).NotEmpty();
    }
}

public sealed class HealthUpdateDtoValidator : AbstractValidator<HealthUpdateDto>
{
    public HealthUpdateDtoValidator()
    {
        RuleFor(x => x.StudentId).NotEmpty();
        RuleFor(x => x.MedicalNotes).NotEmpty().MaximumLength(2000);
        RuleFor(x => x.Allergies).MaximumLength(500);
        RuleFor(x => x.EmergencyContactName).NotEmpty().MaximumLength(150);
        RuleFor(x => x.EmergencyContactPhone).NotEmpty().MaximumLength(30);
        RuleFor(x => x.LastUpdated).NotEmpty();
    }
}
