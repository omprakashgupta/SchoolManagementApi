using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolManagementApi.Api.DTOs.Attendance;
using SchoolManagementApi.Api.DTOs.Common;
using SchoolManagementApi.Api.Services;

namespace SchoolManagementApi.Api.Controllers;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/attendance")]
[Authorize]
public sealed class AttendanceController : ControllerBase
{
    private readonly IAttendanceService _service;

    public AttendanceController(IAttendanceService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<PagedResult<AttendanceDto>>> GetAttendance([FromQuery] QueryParameters query)
    {
        var result = await _service.GetAsync(query);
        return Ok(result);
    }

    [HttpGet("{id:guid}")]
    public async Task<ActionResult<AttendanceDto>> GetRecord(Guid id)
    {
        var record = await _service.GetByIdAsync(id);
        return record == null ? NotFound() : Ok(record);
    }

    [HttpPost]
    [Authorize(Roles = "Admin,Teacher")]
    public async Task<ActionResult<Guid>> CreateRecord([FromBody] AttendanceCreateDto dto)
    {
        var id = await _service.CreateAsync(dto);
        return CreatedAtAction(nameof(GetRecord), new { id, version = "1.0" }, id);
    }

    [HttpPut("{id:guid}")]
    [Authorize(Roles = "Admin,Teacher")]
    public async Task<IActionResult> UpdateRecord(Guid id, [FromBody] AttendanceUpdateDto dto)
    {
        var updated = await _service.UpdateAsync(id, dto);
        return updated ? NoContent() : NotFound();
    }

    [HttpDelete("{id:guid}")]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> DeleteRecord(Guid id)
    {
        var deleted = await _service.DeleteAsync(id);
        return deleted ? NoContent() : NotFound();
    }

    [HttpPost("hooks/biometric")]
    [AllowAnonymous]
    public async Task<ActionResult<Guid>> RecordBiometric([FromBody] BiometricAttendanceHookDto dto)
    {
        var id = await _service.RecordBiometricAsync(dto);
        return Accepted(id);
    }
}
