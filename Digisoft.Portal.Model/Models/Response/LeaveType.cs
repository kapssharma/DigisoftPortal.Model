using System.ComponentModel.DataAnnotations;

namespace DigisoftPortal.Model.Models.Response;

public class LeaveType
{
    public int TotalRows { get; set; }
    public int Id { get; set; }

    [Required]
    [DataType("nvarchar(100)")]
    public string? Description { get; set; }
}
