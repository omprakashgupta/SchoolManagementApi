namespace SchoolManagementApi.Api.Entities;

public sealed class GradeRecord : IEntity
{
    public Guid Id { get; set; }
    public Guid StudentId { get; set; }
    public string Subject { get; set; } = string.Empty;
    public decimal Score { get; set; }
    public string Term { get; set; } = string.Empty;
}
