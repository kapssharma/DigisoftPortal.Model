using System.ComponentModel.DataAnnotations;

namespace DigisoftPortal.Model.Models.Response;

public class UserList
{

    public string? FirstName { get; set; }
    public string? MiddleName { get; set; }
    public string? LastName { get; set; }
    public string? PhoneNumber { get; set; }
    public string? AlternativePhoneNumber { get; set; }
    public string? VoterId { get; set; }
    public string? AadharCardNo { get; set; }
    public string? PanCard { get; set; }
    public string? Email { get; set; }
    public string? OfficialEmail { get; set; }
    public string? ProfileImage { get; set; }
    public string? Password { get; set; }
    [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
    public DateTime DOB { get; set; }
    public int BloodGroup { get; set; }
    public int RoleId { get; set; }
    public int DesignationId { get; set; }
    public bool IsEmailConfirmed { get; set; }
    public bool IsLocked { get; set; }
    public char Gender { get; set; }
    [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
    public DateTime? lockedUntil { get; set; }
    [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
    public DateTime JoiningDate { get; set; }
}
