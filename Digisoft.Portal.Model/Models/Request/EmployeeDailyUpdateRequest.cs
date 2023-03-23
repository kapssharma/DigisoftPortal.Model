
using DigisoftPortal.Model.Models.Shared;

namespace DigisoftPortal.Model.Models.Request;

public class EmployeeDailyUpdateRequest
{
    public List<EmployeeDailyUpdateInsights>? EmployeeDailyUpdateInsights { get; set; }
    public DailyUpdateRequest? DailyUpdateRequest { get; set; }
}
