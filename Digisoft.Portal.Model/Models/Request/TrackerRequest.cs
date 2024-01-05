using DigisoftPortal.Model;
using System.ComponentModel.DataAnnotations;

namespace Digisoft.Portal.Model.Models.Request;
public class TrackerRequest: GenericColumns
{
    [Required]
    public decimal Amount { get; set; }
    public int TrackerTypeID { get; set; }
    public string Description { get; set; }
}
