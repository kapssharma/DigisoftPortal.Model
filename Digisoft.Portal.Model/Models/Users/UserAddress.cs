
using System.ComponentModel.DataAnnotations;

namespace DigisoftPortal.Model;

public class UserAddress
{
    public int ID { get; set; }
    [Required(ErrorMessage = "*")]
    public string? Address1 { get; set; }
    [Required(ErrorMessage = "*")]
    public string? Address2 { get; set; }
    [Required(ErrorMessage = "*")]
    public string? Country { get; set; }
    [Required(ErrorMessage = "*")]
    public string? StateId { get; set; }
    [Required(ErrorMessage = "*")]
    public string? City { get; set; }
    [Required(ErrorMessage = "*")]
    public string? ZipCode { get; set; }
    public bool IsPermanent { get; set; }
}