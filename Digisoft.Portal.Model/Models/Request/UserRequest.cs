using DigisoftPortal.Model;

using System.ComponentModel.DataAnnotations;

public class UserRequest:GenericColumns
{
    [DataType("nvarchar(50)")]
    [Required]
    public string? FirstName { get; set; }
    [DataType("nvarchar(50)")]
    public string? MiddleName { get; set; }
    [DataType("nvarchar(50)")]
    [Required]
    public string? LastName { get; set; }

    [DataType("nvarchar(50)")]
    [Required(ErrorMessage = "Phone Number Required!")]
    [RegularExpression(@"^(0|91)?[6-9][0-9]{9}$", ErrorMessage = "Entered phone format is not valid.")]
    public string? PhoneNumber { get; set; }

    [DataType("nvarchar(50)")]
    [Required(ErrorMessage = "Emergency Number Required!")]
    [RegularExpression(@"^(0|91)?[6-9][0-9]{9}$", ErrorMessage = "Entered phone format is not valid.")]
    public string? AlternativePhoneNumber { get; set; }

    [DataType("nvarchar(50)")]
    public string? VoterId { get; set; }

    [DataType("nvarchar(50)")]
    [Required(ErrorMessage = "Aadhaar Number is required.")]
    [RegularExpression(@"^([0-9]{4}[0-9]{4}[0-9]{4}$)|([0-9]{4}\s[0-9]{4}\s[0-9]{4}$)|([0-9]{4}-[0-9]{4}-[0-9]{4}$)", ErrorMessage = "Invalid Aadhaar Number.")]
    public string? AadharCardNo { get; set; }

    [DataType("nvarchar(50)")]
    [Required(ErrorMessage = "PAN Number is required")]
    [RegularExpression("^([A-Z]){5}([0-9]){4}([A-Z]){1}$", ErrorMessage = "Invalid PAN Number")]
    public string? Pancard { get; set; }

    [Required(ErrorMessage = "Email is required.")]
    [RegularExpression(@"^([A-Za-z0-9][^'!&\\#*$%^?<>()+=:;`~\[\]{}|/,₹€@ ][a-zA-z0-9-._][^!&\\#*$%^?<>()+=:;`~\[\]{}|/,₹€@ ]*\@[a-zA-Z0-9][^!&@\\#*$%^?<> ()+=':;~`.\[\]{}|/,₹€ ]*\.[a-zA-Z]{2,6})$", ErrorMessage = "Please enter a valid Email")]
    [DataType(DataType.EmailAddress)]
    public string? Email { get; set; }
    public string? Password { get; set; }

    [DataType("nvarchar(50)")]
    [Required(ErrorMessage = "Email is required.")]
    [RegularExpression(@"^([A-Za-z0-9][^'!&\\#*$%^?<>()+=:;`~\[\]{}|/,₹€@ ][a-zA-z0-9-._][^!&\\#*$%^?<>()+=:;`~\[\]{}|/,₹€@ ]*\@[a-zA-Z0-9][^!&@\\#*$%^?<> ()+=':;~`.\[\]{}|/,₹€ ]*\.[a-zA-Z]{2,6})$", ErrorMessage = "Please enter a valid Email")]
    public string? OfficialEmail { get; set; }
    public string? ProfileImage { get; set; }

    [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
    public DateTime? DOB { get; set; }

    public int BloodGroup { get; set; }
    public bool IsEmailConfirmed { get; set; }
    public bool IsLocked { get; set; }

    [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
    public DateTime? LockedUntill { get; set; }
    [DataType("char(1)")]
    public char Gender { get; set; }
    [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
    public DateTime? JoiningDate { get; set; }

    [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
    public DateTime? ReleaseDate { get; set; }

    public int DesignationId { get; set; }

    public int RoleId { get; set; }
    public List<UserAddress>? UserAddress { get; set; }
    public UserBankDetail? UserBankDetails { get; set; }
    public List<UserTechnicalInformtion>? UserTechnicalInformtions { get; set; }
    public List<UserDocuments>? UserDocuments { get; set; }
    public List<UserCompany>? UserCompany { get; set; }
    public List<UserGetTOKnows>? UserGetTOKnows { get; set; }
}