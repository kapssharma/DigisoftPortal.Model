using System.ComponentModel.DataAnnotations;

namespace DigisoftPortal.Model.Models.Response;
public class InterviewRound
{
    public int Id { get; set; }

    [Required]
    [DataType("nvarchar(20)")]
    public string? Description { get; set; }
}