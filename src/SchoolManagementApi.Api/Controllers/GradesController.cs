using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolManagementApi.Api.DTOs.Common;
using SchoolManagementApi.Api.DTOs.Grades;
using SchoolManagementApi.Api.Services;

namespace SchoolManagementApi.Api.Controllers;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/grades")]
[Authorize]
public sealed class GradesController : ControllerBase
{
    private readonly IGradeService _service;

    public GradesController(IGradeService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<PagedResult<GradeDto>>> GetGrades([FromQuery] QueryParameters query)
    {
        var result = await _service.GetAsync(query);
        return Ok(result);
    }

    [HttpGet("{id:guid}")]
    public async Task<ActionResult<GradeDto>> GetGrade(Guid id)
    {
        var grade = await _service.GetByIdAsync(id);
        return grade == null ? NotFound() : Ok(grade);
    }

    [HttpPost]
    [Authorize(Roles = "Admin,Teacher")]
    public async Task<ActionResult<Guid>> CreateGrade([FromBody] GradeCreateDto dto)
    {
        var id = await _service.CreateAsync(dto);
        return CreatedAtAction(nameof(GetGrade), new { id, version = "1.0" }, id);
    }

    [HttpPut("{id:guid}")]
    [Authorize(Roles = "Admin,Teacher")]
    public async Task<IActionResult> UpdateGrade(Guid id, [FromBody] GradeUpdateDto dto)
    {
        var updated = await _service.UpdateAsync(id, dto);
        return updated ? NoContent() : NotFound();
    }

    [HttpDelete("{id:guid}")]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> DeleteGrade(Guid id)
    {
        var deleted = await _service.DeleteAsync(id);
        return deleted ? NoContent() : NotFound();
    }
}
