using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolManagementApi.Api.DTOs.Common;
using SchoolManagementApi.Api.DTOs.Teachers;
using SchoolManagementApi.Api.Services;

namespace SchoolManagementApi.Api.Controllers;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/teachers")]
[Authorize]
public sealed class TeachersController : ControllerBase
{
    private readonly ITeacherService _service;

    public TeachersController(ITeacherService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<PagedResult<TeacherDto>>> GetTeachers([FromQuery] QueryParameters query)
    {
        var result = await _service.GetAsync(query);
        return Ok(result);
    }

    [HttpGet("{id:guid}")]
    public async Task<ActionResult<TeacherDto>> GetTeacher(Guid id)
    {
        var teacher = await _service.GetByIdAsync(id);
        return teacher == null ? NotFound() : Ok(teacher);
    }

    [HttpPost]
    [Authorize(Roles = "Admin")]
    public async Task<ActionResult<Guid>> CreateTeacher([FromBody] TeacherCreateDto dto)
    {
        var id = await _service.CreateAsync(dto);
        return CreatedAtAction(nameof(GetTeacher), new { id, version = "1.0" }, id);
    }

    [HttpPut("{id:guid}")]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> UpdateTeacher(Guid id, [FromBody] TeacherUpdateDto dto)
    {
        var updated = await _service.UpdateAsync(id, dto);
        return updated ? NoContent() : NotFound();
    }

    [HttpDelete("{id:guid}")]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> DeleteTeacher(Guid id)
    {
        var deleted = await _service.DeleteAsync(id);
        return deleted ? NoContent() : NotFound();
    }
}
