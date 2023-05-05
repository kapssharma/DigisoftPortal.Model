using DigisoftPortal.Model.Models.Request;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digisoft.Portal.Model.Models.Request
{
    public class FiltersLeavesRequest : FiltersRequest
    {
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? StartFrom { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? StartEnd { get; set; }
        public int LeaveReasons { get; set; }
        public int LeaveType { get; set; }
        public int ApprovedBy { get; set; }
    }
}
