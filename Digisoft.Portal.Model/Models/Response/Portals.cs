using System.ComponentModel.DataAnnotations;

namespace DigisoftPortal.Model.Models.Response;

public class Portals
{
    public int Id { get; set; }

    [DataType("varchar(500)")]
    [Required(ErrorMessage = "Field can't be empty")]
    public string? Title { get; set; }

    [DataType("varchar(50)")]
    [Required(ErrorMessage = "Field can't be empty")]
    public string? ContactPerson { get; set; }

    [DataType("varchar(250)")]
    [Required(ErrorMessage = "Field can't be empty")]
    [EmailAddress(ErrorMessage = "Invalid Email Address")]
    public string? Email { get; set; }

    [DataType("varchar(20)")]
    [Required(ErrorMessage = "Field can't be empty")]
    public string? Phone { get; set; }
    public bool PaidService { get; set; }
    public bool Purchased { get; set; }

    [Required(ErrorMessage = "Field can't be empty")]
    public DateTime ExpiredAt { get; set; }

    [DataType("varchar(500)")]
    [Required(ErrorMessage = "Field can't be empty")]
    public string? Remark { get; set; }
    public DateTime CreatedOn { get; set; }
}
