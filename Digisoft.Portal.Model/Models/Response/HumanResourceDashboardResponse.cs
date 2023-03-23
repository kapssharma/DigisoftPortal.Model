using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digisoft.Portal.Model.Models.Response
{
    public class HumanResourceDashboardResponse
    {
        public int? Today_Leave_Counts { get; set; }
        public int? Current_Hiring_Counts { get; set; }
        public int? Upcomming_Events_Counts { get; set; }
        public int? Upcomming_Leaves_Counts { get; set; }
        public int? New_Joining_Counts { get; set; }
        public int? Missing_Status_Counts { get; set; }
        public int? Notified_Candidates_Counts { get; set; }
        public int? Confirmed_Candidates_Counts { get; set; }
    }
}
