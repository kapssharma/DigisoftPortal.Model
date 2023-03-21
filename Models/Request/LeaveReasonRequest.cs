
using System.ComponentModel.DataAnnotations;
public class LeaveReasonRequest
{
    [StringLength(100)]
    [Required]

    public string Description { get; set; }
}

