namespace SchoolManagementApi.Api.Entities;

public sealed class Announcement : IEntity
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public DateTime PublishDate { get; set; }
    public bool IsUrgent { get; set; }
}
