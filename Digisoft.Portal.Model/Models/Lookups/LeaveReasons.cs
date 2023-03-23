using System.ComponentModel.DataAnnotations;

namespace DigisoftPortal.Model;

public class LeaveReasons:BaseEntity
{
    [DataType("varchar(20)")]
    [Required]

    public string? Description { get; set; }
}