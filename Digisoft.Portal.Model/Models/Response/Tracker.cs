using System.ComponentModel.DataAnnotations;

namespace DigisoftPortal.Model.Models.Response;
public class Tracker
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Expense Amount is Required")]
    public decimal Amount { get; set; }

    [DataType("varchar(200)")]
    [Required(ErrorMessage = "Expense Description is Required")]
    public string? Description { get; set; }

    public int TrackerTypeID { get; set; }
    public string? TrackerType { get; set; }

    public string? SourceType { get; set; }

    public DateTime CreatedOn { get; set; }
}
