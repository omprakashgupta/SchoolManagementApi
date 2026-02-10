namespace SchoolManagementApi.Api.DTOs.Common;

public sealed class QueryParameters
{
    private const int MaxPageSize = 100;

    public int PageNumber { get; set; } = 1;
    public int PageSize { get; set; } = 20;
    public string? Search { get; set; }

    public QueryParameters Normalize()
    {
        if (PageNumber < 1)
        {
            PageNumber = 1;
        }

        if (PageSize < 1)
        {
            PageSize = 20;
        }

        if (PageSize > MaxPageSize)
        {
            PageSize = MaxPageSize;
        }

        return this;
    }
}
