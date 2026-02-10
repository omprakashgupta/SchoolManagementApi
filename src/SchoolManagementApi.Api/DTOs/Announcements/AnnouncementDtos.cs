namespace SchoolManagementApi.Api.DTOs.Announcements;

public sealed class AnnouncementDto
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public DateTime PublishDate { get; set; }
    public bool IsUrgent { get; set; }
}

public sealed class AnnouncementCreateDto
{
    public string Title { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public DateTime PublishDate { get; set; }
    public bool IsUrgent { get; set; }
}

public sealed class AnnouncementUpdateDto
{
    public string Title { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public DateTime PublishDate { get; set; }
    public bool IsUrgent { get; set; }
}
