using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace DigisoftPortal.Model.Models;

public class AuthenticateRequest
{
    [Required]
    public string Email { get; set; }

    [Required]
    public string Password { get; set; }

    [JsonIgnore]
    public string? IpAddress { get; set; }
    [JsonIgnore]
    public string? Browser { get; set; }
    [JsonIgnore]
    public string? Location { get; set; }

    public AuthenticateRequest(string email, string password, string ipAddress, string browser, string location)
    {
        Email = email;
        Password = password;
        IpAddress = ipAddress;
        Browser = browser;
        Location = location;
    }
}
