using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolManagementApi.Api.DTOs.Common;
using SchoolManagementApi.Api.DTOs.Transport;
using SchoolManagementApi.Api.Services;

namespace SchoolManagementApi.Api.Controllers;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/transport")]
[Authorize]
public sealed class TransportController : ControllerBase
{
    private readonly ITransportService _service;

    public TransportController(ITransportService service)
    {
        _service = service;
    }

    [HttpGet("routes")]
    public async Task<ActionResult<PagedResult<TransportRouteDto>>> GetRoutes([FromQuery] QueryParameters query)
    {
        var result = await _service.GetAsync(query);
        return Ok(result);
    }

    [HttpGet("routes/{id:guid}")]
    public async Task<ActionResult<TransportRouteDto>> GetRoute(Guid id)
    {
        var route = await _service.GetByIdAsync(id);
        return route == null ? NotFound() : Ok(route);
    }

    [HttpPost("routes")]
    [Authorize(Roles = "Admin")]
    public async Task<ActionResult<Guid>> CreateRoute([FromBody] TransportRouteCreateDto dto)
    {
        var id = await _service.CreateAsync(dto);
        return CreatedAtAction(nameof(GetRoute), new { id, version = "1.0" }, id);
    }

    [HttpPut("routes/{id:guid}")]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> UpdateRoute(Guid id, [FromBody] TransportRouteUpdateDto dto)
    {
        var updated = await _service.UpdateAsync(id, dto);
        return updated ? NoContent() : NotFound();
    }

    [HttpDelete("routes/{id:guid}")]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> DeleteRoute(Guid id)
    {
        var deleted = await _service.DeleteAsync(id);
        return deleted ? NoContent() : NotFound();
    }

    [HttpPost("alerts")]
    [Authorize(Roles = "Admin,Teacher")]
    public async Task<IActionResult> SendAlert([FromBody] TransportAlertDto dto)
    {
        var sent = await _service.SendAlertAsync(dto);
        return sent ? Accepted() : BadRequest();
    }
}
