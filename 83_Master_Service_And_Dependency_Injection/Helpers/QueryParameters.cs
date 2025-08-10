namespace Helpers;

public class QueryParameters {
    private const int MaxPageSize = 50;

    public int PageNumber { get; set; }
    public int PageSize { get; set; }
    public string? Search { get; set; }
    public string? SortOrder { get; set; }

    // Chaining
    public QueryParameters Validate() {
        if(PageNumber < 1) PageNumber = 1;
        if(PageSize < 1) PageSize = 5;
        if(PageSize > MaxPageSize) PageSize = MaxPageSize;
        return this;
    }
}