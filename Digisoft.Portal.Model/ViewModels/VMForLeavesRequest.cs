using DigisoftPortal.Model.Models;
using DigisoftPortal.Model.Models.Response;

namespace Digisoft.Portal.Web.Models
{
    public class VMForLeavesRequest
    {
        public VMForLeavesRequest()
        {
            LeavesRequest = new LeavesRequest();
            User = new List<User>();
            LeaveReason = new List<LeaveReason>();
            LeaveType = new List<LeaveType>();
        }
        public LeavesRequest LeavesRequest { get; set; }
        public List<User>? User { get; set; }
        public List<LeaveReason>? LeaveReason { get; set; }
        public List<LeaveType>? LeaveType { get; set; }
    }
}
