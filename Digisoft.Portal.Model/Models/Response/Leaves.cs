using System.ComponentModel.DataAnnotations;

namespace DigisoftPortal.Model.Models.Response;

public class Leaves
{
    public int Id { get; set; }
    [Required]
    public int UserLeavesId { get; set; }
    public string? EmployeeName { get; set; }
    public DateTime StartFrom { get; set; }
    public DateTime StartEnd { get; set; }
    public int TotalDays { get; set; }
    public string? LeaveType { get; set; }
    public string? LeaveReasons { get; set; }
    public bool IsApproved { get; set; }
    public DateTime ApprovedAt { get; set; }
    public string? ApprovedBy { get; set; }
    public DateTime CreatedOn { get; set; }
    public bool IsActive { get; set; }

}
