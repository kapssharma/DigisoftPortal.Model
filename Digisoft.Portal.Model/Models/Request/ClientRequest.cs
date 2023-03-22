using System.ComponentModel.DataAnnotations;

namespace DigisoftPortal.Model.Models.Request;

public class ClientRequest:GenericColumns
{
    [DataType("varchar(50)")]
    [Required]
    public string FirstName { get; set; }
    [DataType("varchar(50)")]
    public string? MiddleName { get; set; }
    [DataType("varchar(50)")]
    [Required]
    public string LastName { get; set; }
    [DataType("varchar(250)")]
    [Required]
    [EmailAddress]
    public string Email { get; set; }
    public int SalesSourceID { get; set; }
    [DataType("varchar(20)")]
    [Required]
    [Phone]
    public string PhoneNumber { get; set; }

    [DataType("varchar(100)")]
    public string? Skype { get; set; }
    [DataType("varchar(250)")]
    public string? Facebook { get; set; }
    [DataType("varchar(250)")]
    public string? Twitter { get; set; }
    [DataType("varchar(250)")]
    public string? LinkedIn { get; set; }
    [DataType("varchar(250)")]
    public string? Image { get; set; }
    [Required]
    public DateTime JoinedAt { get; set; }

    [DataType("varchar(150)")]
    [Required]
    public string Company { get; set; }
    [DataType("varchar(50)")]
    public string? Country { get; set; }
    [DataType("varchar(50)")]
    public string? State { get; set; }
    [DataType("varchar(50)")]
    public string? City { get; set; }

    [DataType("varchar(10)")]
    public string? Zip { get; set; }
    [DataType("varchar(250)")]
    public string? ProfileLink { get; set; }
    [DataType("varchar(250)")]
    public string? WebLink { get; set; }

}
