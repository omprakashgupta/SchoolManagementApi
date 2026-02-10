namespace SchoolManagementApi.Api.Entities;

public sealed class FeeRecord : IEntity
{
    public Guid Id { get; set; }
    public Guid StudentId { get; set; }
    public decimal Amount { get; set; }
    public DateTime DueDate { get; set; }
    public string Status { get; set; } = string.Empty;
}
