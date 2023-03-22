using System.ComponentModel.DataAnnotations;

namespace DigisoftPortal.Model.Models.Request;

public class PortalRequest:GenericColumns
{
    [DataType("varchar(500)")]
    [Required]
    public string? Title { get; set; }
    [DataType("varchar(50)")]
    [Required]
    public string? ContactPerson { get; set; }

    [DataType("varchar(250)")]
    [Required]
    public string? Email { get; set; }

    [DataType("varchar(20)")]
    [Required]
    public string? Phone { get; set; }
    public bool PaidService { get; set; }
    public bool Purchased { get; set; }
    [Required]
    public DateTime ExpiredAt { get; set; }
    [DataType("varchar(500)")]
    public string? Remark { get; set; }

 }
