using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace DigisoftPortal.Model.Models;

public class LeavesRequest
{
    [JsonIgnore]
    public int Id { get; set; }
    public int UserId { get; set; }

    [Required]
    public int LeaveReasonId { get; set; }
    [DataType("varchar(2000)")]
    public string? OtherReason { get; set; }
    public bool NotifiyOthers { get; set; }
    [DataType("varchar(2000)")]
    public string? NotifyEmails { get; set; }
    [DataType("varchar(2000)")]
    public string? Notes { get; set; }
    public bool IsApproved { get; set; }
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    public DateTime? ApprovedAt { get; set; }
    public string? ApprovedBy { get; set; }
    public List<LeaveDays>? LeaveDays { get; set; }
}