using System.ComponentModel.DataAnnotations;

namespace DigisoftPortal.Model.Models.Response;

public class User
{

    public int Id { get; set; }
    [DataType("nvarchar(50)")]
    [Required]
    public string? FirstName { get; set; }
    [DataType("nvarchar(50)")]
    public string? MiddleName { get; set; }
    [DataType("nvarchar(50)")]
    [Required]
    public string? LastName { get; set; }
    [DataType("nvarchar(50)")]
    [Required]
    public string? PhoneNumber { get; set; }
    [DataType("nvarchar(50)")]
    [Required]
    public string? AlternativePhoneNumber { get; set; }
    public string? ProfileImage { get; set; }

    [DataType("nvarchar(50)")]
    [Required]
    public string? Email { get; set; }

    [DataType("nvarchar(50)")]
    [Required]
    public string? OfficialEmail { get; set; }
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    public DateTime JoiningDate { get; set; }
    [Required]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    public DateTime DOB { get; set; }
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    public DateTime CreatedOn { get; set; }

}
