using DigisoftPortal.Model.Models.Shared;

using System.ComponentModel.DataAnnotations;

namespace DigisoftPortal.Model.Models.Request;

public class SalesDailyUpdateInsights
{
    public int SaleDailyUpdateInsightsId { get; set; }

    [DataType("varchar(2000)")]
    [Required]
    public string Task { get; set; }
    public int ProjectId { get; set; }
    public bool HelpingHours { get; set; }
    public int HelpingPersonId { get; set; }

    [DataType("time(7)")]
    public TimeSpan BillableHours { get; set; }

    [DataType("time(7)")]
    [Required]
    public TimeSpan SpendHours { get; set; }

    [DataType("varchar(1000)")]
    public string? Notes { get; set; }


}
