using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolManagementApi.Api.DTOs.Analytics;
using SchoolManagementApi.Api.Services;

namespace SchoolManagementApi.Api.Controllers;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/analytics")]
[Authorize]
public sealed class AnalyticsController : ControllerBase
{
    private readonly IAnalyticsService _service;

    public AnalyticsController(IAnalyticsService service)
    {
        _service = service;
    }

    [HttpGet("students")]
    [Authorize(Roles = "Admin,Teacher")]
    public async Task<ActionResult<IReadOnlyList<StudentPerformanceTrendDto>>> GetStudentTrends()
    {
        var result = await _service.GetStudentTrendsAsync();
        return Ok(result);
    }

    [HttpGet("teachers")]
    [Authorize(Roles = "Admin")]
    public async Task<ActionResult<IReadOnlyList<TeacherEffectivenessDto>>> GetTeacherEffectiveness()
    {
        var result = await _service.GetTeacherEffectivenessAsync();
        return Ok(result);
    }

    [HttpGet("resources")]
    [Authorize(Roles = "Admin")]
    public async Task<ActionResult<IReadOnlyList<ResourceUtilizationDto>>> GetResourceUtilization()
    {
        var result = await _service.GetResourceUtilizationAsync();
        return Ok(result);
    }
}
