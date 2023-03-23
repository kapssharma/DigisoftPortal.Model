using System.ComponentModel.DataAnnotations;

namespace DigisoftPortal.Model.Models.Response;

public class Hirings
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Remark { get; set; }

    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    public DateTime StartDate { get; set; }

    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    public DateTime ClosingDate { get; set; }
    public int CandidateRequireds { get; set; }
    public decimal MinPackage { get; set; }
    public decimal MaxPackage { get; set; }
    public int HiredSoFar { get; set; }

    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    public DateTime? CreatedOn { get; set; }
    public bool IsActive { get; set; }
    public string? SkillSet { get; set; }
    public int Experience { get; set; }
}
