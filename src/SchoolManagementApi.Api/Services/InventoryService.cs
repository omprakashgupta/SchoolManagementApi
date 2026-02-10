using AutoMapper;
using SchoolManagementApi.Api.DTOs.Inventory;
using SchoolManagementApi.Api.Entities;
using SchoolManagementApi.Api.Repositories;

namespace SchoolManagementApi.Api.Services;

public interface IInventoryService : ICrudService<InventoryDto, InventoryCreateDto, InventoryUpdateDto>
{
}

public sealed class InventoryService : CrudServiceBase<InventoryAsset, InventoryDto, InventoryCreateDto, InventoryUpdateDto>, IInventoryService
{
    public InventoryService(IInventoryRepository repository, IMapper mapper, IInputSanitizer sanitizer)
        : base(repository, mapper, sanitizer)
    {
    }
}
