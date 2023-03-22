
using System.ComponentModel.DataAnnotations;

namespace DigisoftPortal.Model.ValueTypes;

public class DailyUpdateInsightsType
{
    public int Id { get; set; }
    [DataType("varchar(2000)")]
    public string? Task { get; set; }
    public int ProjectId { get; set; }
    public bool HelpingHours { get; set; }
    public int HelpingPersonId { get; set; }
    [DataType("time(7)")]
    public TimeSpan SpendHours { get; set; }

    [DataType("time(7)")]
    public TimeSpan BillableHours { get; set; }
    [DataType("varchar(1000)")]
    public string? Notes { get; set; }

}
