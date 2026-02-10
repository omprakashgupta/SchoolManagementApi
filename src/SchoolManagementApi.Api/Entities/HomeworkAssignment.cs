namespace SchoolManagementApi.Api.Entities;

public sealed class HomeworkAssignment : IEntity
{
    public Guid Id { get; set; }
    public Guid ClassId { get; set; }
    public string Title { get; set; } = string.Empty;
    public DateTime DueDate { get; set; }
    public string Status { get; set; } = string.Empty;
}
