using System.ComponentModel.DataAnnotations;
using DigisoftPortal.Model;

public class DesignationRequest
{
    [Required]
    [StringLength(100)]
    public string? Name { get; set; }
}

