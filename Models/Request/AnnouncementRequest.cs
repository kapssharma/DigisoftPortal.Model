using System.ComponentModel.DataAnnotations;

namespace DigisoftPortal.Model.Models.Request;

public class AnnouncementRequest:GenericColumns
{
    [DataType("varchar(max)")]
    [Required]
    public string? Description { get; set; }
    [Required]
    public DateTime? EffectiveTo { get; set; }
    public bool Notified { get; set; }

}
