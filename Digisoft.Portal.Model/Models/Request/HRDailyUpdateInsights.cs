using System.ComponentModel.DataAnnotations;

namespace DigisoftPortal.Model.Models.Request;

public class HRDailyUpdateInsights
{
    [DataType("varchar(2000)")]
    [Required]
    public string? Task { get; set; }

    [DataType("time(7)")]
    public TimeSpan SpendHours { get; set; }

    [DataType("varchar(1000)")]
    public string? Notes { get; set; }

}
