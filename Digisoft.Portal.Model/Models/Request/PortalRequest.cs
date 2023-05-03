using System.ComponentModel.DataAnnotations;

namespace DigisoftPortal.Model.Models.Request;

public class PortalRequest :GenericColumns
{

    [DataType("varchar(500)")]
    [Required(ErrorMessage = "Field can't be empty")]
    public string? Title { get; set; }

    [DataType("varchar(50)")]
    [Required(ErrorMessage = "Field can't be empty")]
    public string? ContactPerson { get; set; }

    [Required(ErrorMessage = "Email is required.")]
    [RegularExpression(@"^([A-Za-z0-9][^'!&\\#*$%^?<>()+=:;`~\[\]{}|/,₹€@ ][a-zA-z0-9-._][^!&\\#*$%^?<>()+=:;`~\[\]{}|/,₹€@ ]*\@[a-zA-Z0-9][^!&@\\#*$%^?<> ()+=':;~`.\[\]{}|/,₹€ ]*\.[a-zA-Z]{2,6})$", ErrorMessage = "Please enter a valid Email")]
    [DataType(DataType.EmailAddress)]
    public string? Email { get; set; }

    [DataType("nvarchar(50)")]
    [Required(ErrorMessage = "Phone Number Required!")]
    [RegularExpression(@"^(0|91)?[6-9][0-9]{9}$", ErrorMessage = "Entered phone format is not valid.")]
    public string? Phone { get; set; }
    public bool PaidService { get; set; }
    public bool Purchased { get; set; }

    [Required(ErrorMessage = "Field can't be empty")]
    [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
    public DateTime ExpiredAt { get; set; }

    [DataType("varchar(500)")]
    [Required(ErrorMessage = "Field can't be empty")]
    public string? Remark { get; set; }
    
}