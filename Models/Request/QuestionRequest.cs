using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigisoftPortal.Model.Models
{
    public class QuestionRequest
    {
        [DataType("nvarchar(MAX)")]
        [Required]
        public string Question { get; set; }
    }
}
