using System.ComponentModel.DataAnnotations;

namespace DigisoftPortal.Model.Models.Response;

public class Questions
{

    public int Id { get; set; }
    
    [DataType("nvarchar(MAX)")]
    [Required]
    public string? Question { get; set; }
}
