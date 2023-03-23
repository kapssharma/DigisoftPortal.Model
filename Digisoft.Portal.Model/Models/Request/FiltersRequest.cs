using System.ComponentModel;
namespace DigisoftPortal.Model.Models.Request;

public class FiltersRequest
{
    public string? SearchColumn { get; set; } = "";
    public string? SearchValue { get; set; } = "";
    //[DefaultValue(1)]
    public int PageNo { get; set; } = 1;
    //[DefaultValue(10)]
    public int PageSize { get; set; } = 10;
    public string? SortColumn { get; set; } = "";
    public string? SortOrder { get; set; } = "";
    public bool IsActive { get; set; } = true;
}
