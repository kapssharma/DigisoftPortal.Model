
using DigisoftPortal.Model.Models.Shared;

namespace DigisoftPortal.Model.Models.Request;

public class HRDailyUpdateRequest
{
    public List<HRDailyUpdateInsights>? HRDailyUpdateInsights { get; set; }
    public DailyUpdateRequest? DailyUpdateRequest { get; set; }

}
