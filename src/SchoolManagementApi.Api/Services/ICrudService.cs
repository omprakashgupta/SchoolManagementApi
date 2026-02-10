using SchoolManagementApi.Api.DTOs.Common;

namespace SchoolManagementApi.Api.Services;

public interface ICrudService<TDto, TCreateDto, TUpdateDto>
{
    Task<PagedResult<TDto>> GetAsync(QueryParameters query);
    Task<TDto?> GetByIdAsync(Guid id);
    Task<Guid> CreateAsync(TCreateDto dto);
    Task<bool> UpdateAsync(Guid id, TUpdateDto dto);
    Task<bool> DeleteAsync(Guid id);
}
