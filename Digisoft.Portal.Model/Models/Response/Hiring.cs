
using System.ComponentModel.DataAnnotations;

namespace DigisoftPortal.Model.Models.Response;

public class Hiring
{
    public int Id { get; set; }
    public string? Title { get; set; }
   
    public int MaxExpInYY { get; set; }
    public int MaxExpInMM { get; set; }
  
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    public DateTime? StartDate { get; set; }

    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    public DateTime? ClosingDate { get; set; }
    public int CandidateRequireds { get; set; }
    public decimal MinPackage { get; set; }
    public decimal MaxPackage { get; set; }
    public int HiredSoFar { get; set; }
    public int SkillSet { get; set; }

}
