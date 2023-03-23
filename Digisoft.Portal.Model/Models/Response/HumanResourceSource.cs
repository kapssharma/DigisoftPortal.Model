using System.ComponentModel.DataAnnotations;

namespace DigisoftPortal.Model.Models.Response;
public class HumanResourceSource
{
    public int Id { get; set; }

    [Required]
    [DataType("nvarchar(50)")]
    public string? Name { get; set; }

    [DataType("nvarchar(250)")]
    public string? Icon { get; set; }
}