using AutoMapper;
using SchoolManagementApi.Api.DTOs.Library;
using SchoolManagementApi.Api.Entities;
using SchoolManagementApi.Api.Repositories;

namespace SchoolManagementApi.Api.Services;

public interface ILibraryService : ICrudService<LibraryBookDto, LibraryBookCreateDto, LibraryBookUpdateDto>
{
    Task<bool> IssueBookAsync(Guid bookId, IssueBookDto dto);
    Task<bool> ReturnBookAsync(Guid bookId, ReturnBookDto dto);
}

public sealed class LibraryService : CrudServiceBase<LibraryBook, LibraryBookDto, LibraryBookCreateDto, LibraryBookUpdateDto>, ILibraryService
{
    private readonly ILibraryRepository _repository;

    public LibraryService(ILibraryRepository repository, IMapper mapper, IInputSanitizer sanitizer)
        : base(repository, mapper, sanitizer)
    {
        _repository = repository;
    }

    public async Task<bool> IssueBookAsync(Guid bookId, IssueBookDto dto)
    {
        var book = await _repository.GetByIdAsync(bookId);
        if (book == null || book.AvailableCopies <= 0)
        {
            return false;
        }

        book.AvailableCopies -= 1;
        return await _repository.UpdateAsync(book);
    }

    public async Task<bool> ReturnBookAsync(Guid bookId, ReturnBookDto dto)
    {
        var book = await _repository.GetByIdAsync(bookId);
        if (book == null)
        {
            return false;
        }

        book.AvailableCopies += 1;
        return await _repository.UpdateAsync(book);
    }
}
