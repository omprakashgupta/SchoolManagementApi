using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolManagementApi.Api.DTOs.Common;
using SchoolManagementApi.Api.DTOs.Messaging;
using SchoolManagementApi.Api.Services;

namespace SchoolManagementApi.Api.Controllers;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/messages")]
[Authorize]
public sealed class MessagesController : ControllerBase
{
    private readonly IMessageService _service;

    public MessagesController(IMessageService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<PagedResult<MessageDto>>> GetMessages([FromQuery] QueryParameters query)
    {
        var result = await _service.GetAsync(query);
        return Ok(result);
    }

    [HttpGet("{id:guid}")]
    public async Task<ActionResult<MessageDto>> GetMessage(Guid id)
    {
        var message = await _service.GetByIdAsync(id);
        return message == null ? NotFound() : Ok(message);
    }

    [HttpPost]
    public async Task<ActionResult<Guid>> CreateMessage([FromBody] MessageCreateDto dto)
    {
        var id = await _service.CreateAsync(dto);
        return CreatedAtAction(nameof(GetMessage), new { id, version = "1.0" }, id);
    }

    [HttpPut("{id:guid}")]
    public async Task<IActionResult> UpdateMessage(Guid id, [FromBody] MessageUpdateDto dto)
    {
        var updated = await _service.UpdateAsync(id, dto);
        return updated ? NoContent() : NotFound();
    }

    [HttpDelete("{id:guid}")]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> DeleteMessage(Guid id)
    {
        var deleted = await _service.DeleteAsync(id);
        return deleted ? NoContent() : NotFound();
    }
}
