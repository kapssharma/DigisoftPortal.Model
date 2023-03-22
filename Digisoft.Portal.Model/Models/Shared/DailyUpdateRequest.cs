using System.ComponentModel.DataAnnotations;

namespace DigisoftPortal.Model.Models.Shared;

public class DailyUpdateRequest
{
    [Required]
    public int UserId { get; set; }
    [Required]
    public DateTime TimeStamp { get; set; }
    public bool Notified { get; set; }
    public bool IsSaveDraft { get; set; }
}
