using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace DigisoftPortal.Model;

public class UserWorkingHistory : BaseEntity
{
    [Required]
    public int UserId { get; set; }
    [DataType("nvarchar(100)")]
    [Required]
    public string? Company { get; set; }
    [DataType("decimal(18,4)")]
    [Required]
    public decimal Salary { get; set; }

    //navigation
    [JsonIgnore]
    public virtual Users? User { get; set; }
}