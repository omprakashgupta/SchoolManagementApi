using FluentValidation;
using SchoolManagementApi.Api.DTOs.Announcements;

namespace SchoolManagementApi.Api.Validation;

public sealed class AnnouncementCreateDtoValidator : AbstractValidator<AnnouncementCreateDto>
{
    public AnnouncementCreateDtoValidator()
    {
        RuleFor(x => x.Title).NotEmpty().MaximumLength(200);
        RuleFor(x => x.Content).NotEmpty().MaximumLength(2000);
        RuleFor(x => x.PublishDate).NotEmpty();
    }
}

public sealed class AnnouncementUpdateDtoValidator : AbstractValidator<AnnouncementUpdateDto>
{
    public AnnouncementUpdateDtoValidator()
    {
        RuleFor(x => x.Title).NotEmpty().MaximumLength(200);
        RuleFor(x => x.Content).NotEmpty().MaximumLength(2000);
        RuleFor(x => x.PublishDate).NotEmpty();
    }
}
