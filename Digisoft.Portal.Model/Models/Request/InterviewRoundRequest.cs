using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigisoftPortal.Model.Models
{
    public class InterviewRoundRequest
    {
        [Required]
        [DataType("nvarchar(20)")]
        public string Description { get; set; }
    }
}
