using DigisoftPortal.Model;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digisoft.Portal.Model.ViewModels
{
    public class UserLeave
    {
        public int Id { get; set; }
        public int UserLeavesId { get; set; }
        public string? EmployeeName { get; set; }
        public string? LeaveReasons { get; set; }
        public string? ApprovedBy { get; set; }
        public string? ApprovedBy1 { get; set; }
        public int ApprovedByID { get; set; }
        public string? ApprovedBy1ID { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? CreatedOn { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? ApprovedAt { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? ApprovedAt1 { get; set; }
        public bool IsActive { get; set; }
        public List<UserLeaveDays>? UserLeaveDays { get; set; }
    }
}
