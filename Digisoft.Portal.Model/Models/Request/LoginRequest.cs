using System.ComponentModel.DataAnnotations;
namespace DigisoftPortal.Model.Models;

public class LoginRequest
{
    public LoginRequest(string email, string password)
    {
        Email = email;
        Password = password;
    }

    [Required]
    public string Email { get; set; }
    [Required]
    public string Password { get; set; }
}