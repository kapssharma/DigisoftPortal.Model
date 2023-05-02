using System.ComponentModel.DataAnnotations;

namespace Digisoft.Portal.Model.Models.Request;

public class CurrentHiringFiltersRequest
{
    public string? Title { get; set; }
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    public DateTime? StartDate { get; set; }
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    public DateTime? ClosingDate { get; set; }
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    public DateTime? CreatedOn { get; set; }
    public string? SkillSet { get; set; }
    public decimal? MaxPackage { get; set; }
    public decimal? MinPackage { get; set; }
    public string? SearchValue { get; set; } = "";
    public int PageNo { get; set; } = 1;
    public int PageSize { get; set; } = 10;
    public string? SortColumn { get; set; } = "";
    public string? SortOrder { get; set; } = "";
    public bool IsActive { get; set; } = true;
}
