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
    [EmailAddress]
    public string? NotifyEmails { get; set; }
    [DataType("varchar(2000)")]
    public string Notes { get; set; }
    public bool ApprovedBy { get; set; }
    public DateTime ApprovedAt { get; set; }
    public bool ApprovedBy1 { get; set; }
    public DateTime ApprovedAt1 { get; set; }
    public List<LeaveDays>? LeaveDays { get; set; }
}