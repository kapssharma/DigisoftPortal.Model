using System.ComponentModel.DataAnnotations;

namespace DigisoftPortal.Model.Models.Request;

public class StreamRequest
{
    [StringLength(50)]
    [Required]

    public string? Name { get; set; }
}