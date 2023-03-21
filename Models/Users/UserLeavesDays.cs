using System.ComponentModel.DataAnnotations;

namespace DigisoftPortal.Model;

public class UserLeavesDays: BaseEntity
{
    [Required]
    public int UserLeavesID { get; set; }
    [Required]
    public DateTime From { get; set; }
    [Required]
    public DateTime To { get; set; }
    [Required]
    public int LeaveTypeID { get; set; }
}