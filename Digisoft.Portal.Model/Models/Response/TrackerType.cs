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
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public int TypeId { get; set; }
        [Required]
        public bool IsActive { get; set; }
    }
}
