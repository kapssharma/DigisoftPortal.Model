using DigisoftPortal.Model;

using System.ComponentModel.DataAnnotations;

public class UserRequest
{
    [DataType("nvarchar(50)")]
   
    public string? FirstName { get; set; }
    [DataType("nvarchar(50)")]
    public string? MiddleName { get; set; }
    [DataType("nvarchar(50)")]
   
    public string? LastName { get; set; }
    [DataType("nvarchar(50)")]
    
    public string? PhoneNumber { get; set; }
    [DataType("nvarchar(50)")]
    public string? AlternativePhoneNumber { get; set; }
    [DataType("nvarchar(50)")]
   
    public string? VoterId { get; set; }
    [DataType("nvarchar(50)")]
   
    public string? AadharCardNo { get; set; }
    [DataType("nvarchar(50)")]
   
    public string? Pancard { get; set; }
    [DataType("nvarchar(50)")]
   
    public string? Email { get; set; }

   
    public string? Password { get; set; }

    [DataType("nvarchar(50)")]
   
    public string? OfficialEmail { get; set; }
    public string? ProfileImage { get; set; }
    
    public DateTime DOB { get; set; }
    
    public int BloodGroup { get; set; }
    public bool IsEmailConfirmed { get; set; }
    public bool IsLocked { get; set; }
   
    public DateTime LockedUntill { get; set; }
    [DataType("char(1)")] 
    public char Gender { get; set; }
  
    public DateTime JoiningDate { get; set; }
 
    public int DesignationId { get; set; }
  
    public int RoleId { get; set; }
    public List<UserAddress>? UserAddress { get; set; }
    public UserBankDetail? UserBankDetails { get; set; }
    public List<UserTechnicalInformtion>? UserTechnicalInformtions { get; set; }
    public List<UserDocuments>? UserDocuments { get; set; }
    public List<UserCompany>? UserCompany { get; set; }
    public List<UserGetTOKnows>? UserGetTOKnows { get; set; }

}