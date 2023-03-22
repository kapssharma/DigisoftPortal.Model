using DigisoftPortal.Model.Models.Shared;

namespace DigisoftPortal.Model.Models.Response;

public class LeaveTypeResponse
{
    public Pagination Pagination { get; set; }
    public List<LeaveType>? LeaveTypes { get; set; }
}
