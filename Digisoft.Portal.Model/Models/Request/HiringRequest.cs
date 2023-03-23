
using System.ComponentModel.DataAnnotations;

namespace DigisoftPortal.Model.Models.Request;

public class HiringRequest:GenericColumns
{
    [DataType("varchar(500)")]
    [Required]
    public string? Title {get; set;}
    [Required]
    public int MinExpInYY { get; set;}
    [Required]
    public int MinExpInMM { get; set; }
    [Required]
    public int MaxExpInYY { get; set; }
    [Required]
    public int MaxExpInMM { get; set; }
    [DataType("varchar(500)")]
    public string? Remark { get; set; }

    [Required]
    public DateTime StartDate { get; set; }
    public DateTime ClosingDate { get; set; }
    public int CandidateRequireds { get; set; }
    public decimal MinPackage { get; set; }
    public decimal MaxPackage { get; set; }
    public int HiredSoFar { get; set; }
    public int SkillSetId { get; set; }

}
