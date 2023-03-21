using System.ComponentModel.DataAnnotations;

namespace DigisoftPortal.Model.Models.Request;

public class HRLeadInterviewsRequest:GenericColumns
{
    [Required]
    public int LeadId { get; set; }
    
    [Required]
    public DateTime InterviewTime { get; set; }
    
    [Required]
    public int TakenById { get; set; }
    public int? RoundId { get; set; }
    public int? MediumId { get; set; }
    
    [Required]
    public decimal ScoreEarn { get; set; }

    [Required]
    public decimal OutOf { get; set; }
    [DataType("varchar(200)")]
    public string? Remark { get; set; }
    public bool JoinedInterview { get; set; }
   
}
