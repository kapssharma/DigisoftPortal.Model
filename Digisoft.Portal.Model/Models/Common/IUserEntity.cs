namespace DigisoftPortal.Model;

public interface IUserEntity
{
    public string? FirstName { get; set; }
    public string? MiddleName { get; set; }
    public string? LastName { get; set; }
    public string? PhoneNumber { get; set; }
    public string? AlternativePhoneNumber { get; set; }
    public string? Email { get; set; }
    public string? ProfileImage { get; set; }
  
}
