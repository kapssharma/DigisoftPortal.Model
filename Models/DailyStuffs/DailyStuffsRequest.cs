using System.ComponentModel.DataAnnotations;

namespace DigisoftPortal.Model.Models.DailyStuffs;

public class DailyStuffsRequest : GenericColumns
{
    [Required]
    public string? Description { get; set; }
}
