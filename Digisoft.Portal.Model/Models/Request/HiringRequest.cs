
using System.ComponentModel.DataAnnotations;

namespace DigisoftPortal.Model.Models.Request;

public class HiringRequest:GenericColumns
{
    [DataType("varchar(500)")]
    [Required(ErrorMessage = "Please Enter Title")]
    public string? Title {get; set;}
   
    public int MinExpInYY { get; set;}
    
    public int MinExpInMM { get; set; }
    [Required]
    public int MaxExpInYY { get; set; }
    [Required]
    public int MaxExpInMM { get; set; }
    [DataType("varchar(500)")]
    public string? Remark { get; set; }

    [Required(ErrorMessage = "Please Enter Date")]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    public DateTime StartDate { get; set; }

    [Required(ErrorMessage = "Please Enter Date")]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    public DateTime ClosingDate { get; set; }
    public int CandidateRequireds { get; set; }
    public decimal MinPackage { get; set; }
    public decimal MaxPackage { get; set; }
    public int HiredSoFar { get; set; }
    [Required(ErrorMessage = "Please Enter Skills")]
    public int SkillSetId { get; set; }

}
