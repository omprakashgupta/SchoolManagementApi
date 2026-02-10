using FluentValidation;
using SchoolManagementApi.Api.DTOs.Messaging;

namespace SchoolManagementApi.Api.Validation;

public sealed class MessageCreateDtoValidator : AbstractValidator<MessageCreateDto>
{
    public MessageCreateDtoValidator()
    {
        RuleFor(x => x.SenderId).NotEmpty();
        RuleFor(x => x.RecipientId).NotEmpty();
        RuleFor(x => x.Content).NotEmpty().MaximumLength(1000);
        RuleFor(x => x.SentAt).NotEmpty();
    }
}

public sealed class MessageUpdateDtoValidator : AbstractValidator<MessageUpdateDto>
{
    public MessageUpdateDtoValidator()
    {
        RuleFor(x => x.SenderId).NotEmpty();
        RuleFor(x => x.RecipientId).NotEmpty();
        RuleFor(x => x.Content).NotEmpty().MaximumLength(1000);
        RuleFor(x => x.SentAt).NotEmpty();
    }
}
