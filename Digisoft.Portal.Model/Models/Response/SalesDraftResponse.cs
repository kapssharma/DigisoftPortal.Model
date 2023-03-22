
namespace DigisoftPortal.Model.Models.Response;

public class SalesDraftResponse
{
    public int Id { get; set; }
    public int ClientId { get; set; }
    public int SalesSourceId { get; set; }
    public int BidAccountId { get; set; }
    public string? LeadURL { get; set; }
    public DateTime ApplyAt { get; set; }
    public int ConnectUsed { get; set; }
    public decimal AmountUsed { get; set; }
    public int StreamId { get; set; }
    public bool IsFixedPrice { get; set; }
    public decimal AmountOrHourlyRate { get; set; }
    public string? Remark { get; set; }
}
