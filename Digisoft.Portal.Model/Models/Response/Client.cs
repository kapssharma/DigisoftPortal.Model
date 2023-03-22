namespace DigisoftPortal.Model.Models.Response;

public class Client
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string? MiddleName { get; set; }
    public string? LastName { get; set; }
    public string Email { get; set; }
    public int SalesSourceID { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Skype { get; set; }
    public string? Facebook { get; set; }
    public string? Twitter { get; set; }
    public string? LinkedIn { get; set; }
    public string? Image { get; set; }
    public DateTime JoinedAt { get; set; }
    public string? Company { get; set; }
    public string? Country { get; set; }
    public string? State { get; set; }
    public string? City { get; set; }
    public string? Zip { get; set; }
    public string? ProfileLink { get; set; }
    public string? WebLink { get; set; }
}
