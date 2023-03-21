using System.ComponentModel.DataAnnotations;

namespace DigisoftPortal.Model.Models
{
    public class SalesSourcesRequest
    {
       
        [DataType("nvarchar(50)")]
        [Required]
        public string Name { get; set; }

        [DataType("nvarchar(250)")]
        public string Icon { get; set; }
    }
}
