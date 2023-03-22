using DigisoftPortal.Model;

using System.ComponentModel.DataAnnotations;

public class UserRequest
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
    [Required]
    public string? PhoneNumber { get; set; }
    [DataType("nvarchar(50)")]
    public string? AlternativePhoneNumber { get; set; }
    [DataType("nvarchar(50)")]
    [Required]
    public string? VoterId { get; set; }
    [DataType("nvarchar(50)")]
    [Required]
    public string? AadharCardNo { get; set; }
    [DataType("nvarchar(50)")]
    [Required]
    public string? Pancard { get; set; }
    [DataType("nvarchar(50)")]
    [Required]
    public string? Email { get; set; }

    [Required]
    public string? Password { get; set; }

    [DataType("nvarchar(50)")]
    [Required]
    public string? OfficialEmail { get; set; }
    public string? ProfileImage { get; set; }
    [Required]
    public DateTime DOB { get; set; }
    [Required]
    public int BloodGroup { get; set; }
    public bool IsEmailConfirmed { get; set; }
    public bool IsLocked { get; set; }
    [Required]
    public DateTime LockedUntill { get; set; }
    [DataType("char(1)")]
    [Required]
    public char Gender { get; set; }
    [Required]
    public DateTime JoiningDate { get; set; }
    [Required]
    public int DesignationId { get; set; }
    [Required]
    public int RoleId { get; set; }
    public List<UserAddress>? UserAddress { get; set; }
    public UserBankDetail? UserBankDetails { get; set; }
    public List<UserTechnicalInformtion>? UserTechnicalInformtions { get; set; }
    public List<UserDocuments>? UserDocuments { get; set; }
    public List<UserCompany>? UserCompany { get; set; }
    public List<UserGetTOKnows>? UserGetTOKnows { get; set; }

}