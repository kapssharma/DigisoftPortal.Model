using System.ComponentModel.DataAnnotations;

namespace DigisoftPortal.Model.Models.Request;

public class HRLeadTechnicalInformation
{
    public int HRLeadTechnicalInformationId { get; set; }
    public int LeadID { get; set; }
    [Required]
    public int SkillSetID { get; set; }
    public decimal ExpInYY { get; set; }
    public decimal ExpInMM { get; set; }

}
