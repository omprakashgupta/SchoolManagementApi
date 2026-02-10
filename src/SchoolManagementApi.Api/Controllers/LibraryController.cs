using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolManagementApi.Api.DTOs.Common;
using SchoolManagementApi.Api.DTOs.Library;
using SchoolManagementApi.Api.Services;

namespace SchoolManagementApi.Api.Controllers;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/library")]
[Authorize]
public sealed class LibraryController : ControllerBase
{
    private readonly ILibraryService _service;

    public LibraryController(ILibraryService service)
    {
        _service = service;
    }

    [HttpGet("books")]
    public async Task<ActionResult<PagedResult<LibraryBookDto>>> GetBooks([FromQuery] QueryParameters query)
    {
        var result = await _service.GetAsync(query);
        return Ok(result);
    }

    [HttpGet("books/{id:guid}")]
    public async Task<ActionResult<LibraryBookDto>> GetBook(Guid id)
    {
        var book = await _service.GetByIdAsync(id);
        return book == null ? NotFound() : Ok(book);
    }

    [HttpPost("books")]
    [Authorize(Roles = "Admin,Teacher")]
    public async Task<ActionResult<Guid>> CreateBook([FromBody] LibraryBookCreateDto dto)
    {
        var id = await _service.CreateAsync(dto);
        return CreatedAtAction(nameof(GetBook), new { id, version = "1.0" }, id);
    }

    [HttpPut("books/{id:guid}")]
    [Authorize(Roles = "Admin,Teacher")]
    public async Task<IActionResult> UpdateBook(Guid id, [FromBody] LibraryBookUpdateDto dto)
    {
        var updated = await _service.UpdateAsync(id, dto);
        return updated ? NoContent() : NotFound();
    }

    [HttpDelete("books/{id:guid}")]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> DeleteBook(Guid id)
    {
        var deleted = await _service.DeleteAsync(id);
        return deleted ? NoContent() : NotFound();
    }

    [HttpPost("books/{id:guid}/issue")]
    [Authorize(Roles = "Admin,Teacher")]
    public async Task<IActionResult> IssueBook(Guid id, [FromBody] IssueBookDto dto)
    {
        var issued = await _service.IssueBookAsync(id, dto);
        return issued ? Accepted() : BadRequest();
    }

    [HttpPost("books/{id:guid}/return")]
    [Authorize(Roles = "Admin,Teacher")]
    public async Task<IActionResult> ReturnBook(Guid id, [FromBody] ReturnBookDto dto)
    {
        var returned = await _service.ReturnBookAsync(id, dto);
        return returned ? Accepted() : BadRequest();
    }
}
