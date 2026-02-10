using AutoMapper;
using SchoolManagementApi.Api.DTOs.Common;
using SchoolManagementApi.Api.Entities;
using SchoolManagementApi.Api.Repositories;

namespace SchoolManagementApi.Api.Services;

public abstract class CrudServiceBase<TEntity, TDto, TCreateDto, TUpdateDto> : ICrudService<TDto, TCreateDto, TUpdateDto>
    where TEntity : class, IEntity
{
    private readonly ICrudRepository<TEntity> _repository;
    private readonly IMapper _mapper;
    private readonly IInputSanitizer _sanitizer;

    protected CrudServiceBase(ICrudRepository<TEntity> repository, IMapper mapper, IInputSanitizer sanitizer)
    {
        _repository = repository;
        _mapper = mapper;
        _sanitizer = sanitizer;
    }

    public async Task<PagedResult<TDto>> GetAsync(QueryParameters query)
    {
        var result = await _repository.GetAsync(query);
        var mapped = result.Items.Select(item => _mapper.Map<TDto>(item)).ToList();
        return new PagedResult<TDto>(mapped, result.TotalCount, result.PageNumber, result.PageSize);
    }

    public async Task<TDto?> GetByIdAsync(Guid id)
    {
        var entity = await _repository.GetByIdAsync(id);
        return entity == null ? default : _mapper.Map<TDto>(entity);
    }

    public async Task<Guid> CreateAsync(TCreateDto dto)
    {
        var sanitized = _sanitizer.Sanitize(dto);
        var entity = _mapper.Map<TEntity>(sanitized);
        return await _repository.CreateAsync(entity);
    }

    public async Task<bool> UpdateAsync(Guid id, TUpdateDto dto)
    {
        var sanitized = _sanitizer.Sanitize(dto);
        var entity = _mapper.Map<TEntity>(sanitized);
        entity.Id = id;
        return await _repository.UpdateAsync(entity);
    }

    public Task<bool> DeleteAsync(Guid id)
    {
        return _repository.DeleteAsync(id);
    }
}
