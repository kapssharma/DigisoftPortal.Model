using System.ComponentModel.DataAnnotations;

namespace Digisoft.Portal.Model.Models.Request;

public class PortalFiltersRequest
{
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    public DateTime? ValidFrom { get; set; }
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    public DateTime? ValidTo { get; set; }
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    public DateTime? CreatedOn { get; set; }
    public bool? PaidService { get; set; }
    public bool? Purchased { get; set; }
    public string? SearchValue { get; set; } = "";
    public int PageNo { get; set; } = 1;
    public int PageSize { get; set; } = 10;
    public string? SortColumn { get; set; } = "";
    public string? SortOrder { get; set; } = "";
    public bool IsActive { get; set; } = true;
}
