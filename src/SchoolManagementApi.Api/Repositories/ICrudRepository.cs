using SchoolManagementApi.Api.DTOs.Common;
using SchoolManagementApi.Api.Entities;

namespace SchoolManagementApi.Api.Repositories;

public interface ICrudRepository<T> where T : class, IEntity
{
    Task<PagedResult<T>> GetAsync(QueryParameters query);
    Task<T?> GetByIdAsync(Guid id);
    Task<Guid> CreateAsync(T entity);
    Task<bool> UpdateAsync(T entity);
    Task<bool> DeleteAsync(Guid id);
}
