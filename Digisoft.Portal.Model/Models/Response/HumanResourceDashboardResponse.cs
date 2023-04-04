using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digisoft.Portal.Model.Models.Response
{
    public class HumanResourceDashboardResponse
    {
        public int? Today_Leave_Count { get; set; }
        public int? Current_Hiring_Count { get; set; }
        public int? Upcoming_Events_Count { get; set; }
        public int? Upcoming_Leaves_Count { get; set; }
        public int? New_Joining_Count { get; set; }
        public int? Missing_Status_Count { get; set; }
        public int? Notified_Candidates_Count { get; set; }
        public int? Confirmed_Candidates_Count { get; set; }
    }
}
