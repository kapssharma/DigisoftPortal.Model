using System.ComponentModel.DataAnnotations;

namespace DigisoftPortal.Model.Models.Request;

public class SalesLeads
{
    [Required]
    public int Id { get; set; }
    [Required]
    public int ClientId { get; set; }
    public int SalesSourceId { get; set; }
    public int BidAccountId { get; set; }

    [DataType("varchar(2000)")]
    public string? LeadURL { get; set; }
    [Required]
    public DateTime ApplyAt { get; set; }
    public int ConnectUsed { get; set; }
    public decimal AmountUsed { get; set; }
    public int StreamId { get; set; }

    public bool IsFixedPrice { get; set; }

    public decimal AmountOrHourlyRate { get; set; }
    [DataType("varchar(2000)")]
    public string? Remark { get; set; }

}
