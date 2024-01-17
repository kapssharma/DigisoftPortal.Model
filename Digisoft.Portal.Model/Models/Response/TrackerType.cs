using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digisoft.Portal.Model.Models.Response
{
    public class TrackerType
    {
        public int SourceID { get; set; }
        [Required]
        public string? SourceName { get; set; }
        [Required]
        public int TypeID { get; set; }
        [Required]
        public bool IsActive { get; set; }
    }
}
