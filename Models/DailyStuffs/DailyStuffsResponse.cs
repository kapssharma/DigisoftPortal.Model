using DigisoftPortal.Model.Models.Shared;

namespace DigisoftPortal.Model.Models.DailyStuffs;

public class DailyStuffsResponse
{
    public Pagination Pagination { get; set; }
    public List<DailyStuffs>? DailyStuffs { get; set; }
}
