using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolManagementApi.Api.DTOs.Common;
using SchoolManagementApi.Api.DTOs.Exams;
using SchoolManagementApi.Api.Services;

namespace SchoolManagementApi.Api.Controllers;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/exams")]
[Authorize]
public sealed class ExamsController : ControllerBase
{
    private readonly IExamService _service;

    public ExamsController(IExamService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<PagedResult<ExamDto>>> GetExams([FromQuery] QueryParameters query)
    {
        var result = await _service.GetAsync(query);
        return Ok(result);
    }

    [HttpGet("{id:guid}")]
    public async Task<ActionResult<ExamDto>> GetExam(Guid id)
    {
        var exam = await _service.GetByIdAsync(id);
        return exam == null ? NotFound() : Ok(exam);
    }

    [HttpPost]
    [Authorize(Roles = "Admin,Teacher")]
    public async Task<ActionResult<Guid>> CreateExam([FromBody] ExamCreateDto dto)
    {
        var id = await _service.CreateAsync(dto);
        return CreatedAtAction(nameof(GetExam), new { id, version = "1.0" }, id);
    }

    [HttpPut("{id:guid}")]
    [Authorize(Roles = "Admin,Teacher")]
    public async Task<IActionResult> UpdateExam(Guid id, [FromBody] ExamUpdateDto dto)
    {
        var updated = await _service.UpdateAsync(id, dto);
        return updated ? NoContent() : NotFound();
    }

    [HttpDelete("{id:guid}")]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> DeleteExam(Guid id)
    {
        var deleted = await _service.DeleteAsync(id);
        return deleted ? NoContent() : NotFound();
    }
}
