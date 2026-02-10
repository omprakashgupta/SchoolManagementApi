using AutoMapper;
using SchoolManagementApi.Api.DTOs.Announcements;
using SchoolManagementApi.Api.Entities;
using SchoolManagementApi.Api.Repositories;

namespace SchoolManagementApi.Api.Services;

public interface IAnnouncementService : ICrudService<AnnouncementDto, AnnouncementCreateDto, AnnouncementUpdateDto>
{
}

public sealed class AnnouncementService : CrudServiceBase<Announcement, AnnouncementDto, AnnouncementCreateDto, AnnouncementUpdateDto>, IAnnouncementService
{
    public AnnouncementService(IAnnouncementRepository repository, IMapper mapper, IInputSanitizer sanitizer)
        : base(repository, mapper, sanitizer)
    {
    }
}
