using DigisoftPortal.Model.Models.Shared;

namespace DigisoftPortal.Model.Models.Request;

public class SalesDailyUpdateRequest
{
    public List<SalesDailyUpdateInsights> SalesDailyUpdateInsights { get; set; }
    public List<SalesLeads> SalesLeads { get; set; }

    public DailyUpdateRequest DailyUpdateRequest { get; set; }


}
