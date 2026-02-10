using AutoMapper;
using SchoolManagementApi.Api.DTOs.Messaging;
using SchoolManagementApi.Api.Entities;
using SchoolManagementApi.Api.Repositories;

namespace SchoolManagementApi.Api.Services;

public interface IMessageService : ICrudService<MessageDto, MessageCreateDto, MessageUpdateDto>
{
}

public sealed class MessageService : CrudServiceBase<Message, MessageDto, MessageCreateDto, MessageUpdateDto>, IMessageService
{
    public MessageService(IMessageRepository repository, IMapper mapper, IInputSanitizer sanitizer)
        : base(repository, mapper, sanitizer)
    {
    }
}
