using FluentValidation;
using SchoolManagementApi.Api.DTOs.Library;

namespace SchoolManagementApi.Api.Validation;

public sealed class LibraryBookCreateDtoValidator : AbstractValidator<LibraryBookCreateDto>
{
    public LibraryBookCreateDtoValidator()
    {
        RuleFor(x => x.Title).NotEmpty().MaximumLength(200);
        RuleFor(x => x.Author).NotEmpty().MaximumLength(150);
        RuleFor(x => x.Isbn).NotEmpty().MaximumLength(30);
        RuleFor(x => x.AvailableCopies).GreaterThanOrEqualTo(0);
    }
}

public sealed class LibraryBookUpdateDtoValidator : AbstractValidator<LibraryBookUpdateDto>
{
    public LibraryBookUpdateDtoValidator()
    {
        RuleFor(x => x.Title).NotEmpty().MaximumLength(200);
        RuleFor(x => x.Author).NotEmpty().MaximumLength(150);
        RuleFor(x => x.Isbn).NotEmpty().MaximumLength(30);
        RuleFor(x => x.AvailableCopies).GreaterThanOrEqualTo(0);
    }
}

public sealed class IssueBookDtoValidator : AbstractValidator<IssueBookDto>
{
    public IssueBookDtoValidator()
    {
        RuleFor(x => x.StudentId).NotEmpty();
        RuleFor(x => x.DueDate).GreaterThan(DateTime.UtcNow.Date.AddDays(-1));
    }
}

public sealed class ReturnBookDtoValidator : AbstractValidator<ReturnBookDto>
{
    public ReturnBookDtoValidator()
    {
        RuleFor(x => x.ReturnedAt).NotEmpty();
    }
}
