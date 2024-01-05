using DigisoftPortal.Model;
using System.ComponentModel.DataAnnotations;

namespace Digisoft.Portal.Model.Models.Request;
public class TrackerRequest: GenericColumns
{
    [Required]
    public decimal Amount { get; set; }
    [DataType("varchar(200)")]
    [Required(ErrorMessage = "Source Type is Required")]
    public int TrackerTypeID { get; set; }

    [DataType("varchar(200)")]
    [Required(ErrorMessage = "Expense Description is Required")]
    public string? Description { get; set; }
}
