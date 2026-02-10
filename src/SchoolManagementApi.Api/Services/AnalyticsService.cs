using SchoolManagementApi.Api.DTOs.Analytics;

namespace SchoolManagementApi.Api.Services;

public interface IAnalyticsService
{
    Task<IReadOnlyList<StudentPerformanceTrendDto>> GetStudentTrendsAsync();
    Task<IReadOnlyList<TeacherEffectivenessDto>> GetTeacherEffectivenessAsync();
    Task<IReadOnlyList<ResourceUtilizationDto>> GetResourceUtilizationAsync();
}

public sealed class AnalyticsService : IAnalyticsService
{
    public Task<IReadOnlyList<StudentPerformanceTrendDto>> GetStudentTrendsAsync()
    {
        return Task.FromResult<IReadOnlyList<StudentPerformanceTrendDto>>(Array.Empty<StudentPerformanceTrendDto>());
    }

    public Task<IReadOnlyList<TeacherEffectivenessDto>> GetTeacherEffectivenessAsync()
    {
        return Task.FromResult<IReadOnlyList<TeacherEffectivenessDto>>(Array.Empty<TeacherEffectivenessDto>());
    }

    public Task<IReadOnlyList<ResourceUtilizationDto>> GetResourceUtilizationAsync()
    {
        return Task.FromResult<IReadOnlyList<ResourceUtilizationDto>>(Array.Empty<ResourceUtilizationDto>());
    }
}
