using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digisoft.Portal.Model.ViewModels
{
    public class VMForUserLeave
    {
        public VMForUserLeave() {
            UserLeaveDays = new List<UserLeaveDays>();
        } 
        public int Id { get; set; }
        public int UserLeavesId { get; set; }
        public string? EmployeeName { get; set; }
        public string? LeaveReasons { get; set; }
        public bool IsApproved { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? ApprovedAt { get; set; }
        public string? ApprovedBy { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? CreatedOn { get; set; }
        public bool IsActive { get; set; }
        public List<UserLeaveDays>? UserLeaveDays { get; set; }
    }
}
