using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigisoftPortal.Model.Models
{
    public class LeaveTypeRequest
    {
        
        [DataType("nvarchar(100)")]
        [Required]
        public string? Description { get; set; } 
    }
}
