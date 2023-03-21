using System.ComponentModel.DataAnnotations;

namespace DigisoftPortal.Model;

public class UserPassword 
{
    [Required]
    public int UserId { get; set; }
    [DataType("nvarchar(50)")]
    [Required]
    public string? Password { get; set; }
    [DataType("nvarchar(50)")]
    [Required]
    public string? Salt { get; set; }
    [Required]
    public DateTime ExpiryOn { get; set; }
}