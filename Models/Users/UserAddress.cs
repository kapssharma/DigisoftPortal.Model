
using System.ComponentModel.DataAnnotations;

namespace DigisoftPortal.Model;

public class UserAddress
{
    public int UserAddressId { get; set; }
    [Required]
    public string? Address1 { get; set; }
    public string? Address2 { get; set; }
    [Required]
    public string? Country { get; set; }
    [Required]
    public int StateId { get; set; }
    [Required]
    public string? City { get; set; }
    [Required]
    public string? ZipCode { get; set; }
    public bool IsPermanent { get; set; }
}