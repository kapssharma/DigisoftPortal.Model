using System.ComponentModel.DataAnnotations;

namespace DigisoftPortal.Model.Models.Request;

public class EventRequest:GenericColumns
{
    [Required]
    [DataType("varchar(100)")]
    [MaxLength(length:100)]
    public string? Title { get; set; }

    [DataType("varchar(450)")]
    [MaxLength(length: 450)]
    public string? Description { get; set; }

    public bool AllDay { get; set; }
    [Required]
    public DateTime StartDate { get; set; }
    [Required]
    public DateTime EndDate { get; set; }
    [Required]
    public TimeSpan StartTime { get; set; }
    [Required]
    public TimeSpan EndTime { get; set; }

    [DataType("varchar(30)")]
    [MaxLength(length: 30)]
    public string? ColorCode { get; set; }
    public bool EmailNotified { get; set; }
    public bool ShowNotification { get; set; }
}
