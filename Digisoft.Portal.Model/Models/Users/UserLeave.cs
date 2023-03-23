using System.ComponentModel.DataAnnotations;

namespace DigisoftPortal.Model;

public class UserLeave : BaseEntity
{
    [Required]
    public int UserId { get; set; }
    [DataType("varchar(2000)")]
    [Required]
    public string? OtherReason { get; set; }
    public bool NotifiyOthers { get; set; }

    [DataType("varchar(2000)")]
    public string? NotifyEmails { get; set; }
    [Required]
    public bool IsApproved { get; set; }
    [Required]
    public DateTime ApprovedByAt { get; set; }
    [Required]
    public DateTime ApprovedBy1At { get; set; }
    [Required]
    public DateTime ApprovedBy { get; set; }
    [Required]
    public DateTime ApprovedBy1 { get; set; }

    [DataType("varchar(2000)")]
    [Required]
    public byte Notes { get; set; }
   
}