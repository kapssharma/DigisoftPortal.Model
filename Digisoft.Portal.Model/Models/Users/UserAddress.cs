
using System.ComponentModel.DataAnnotations;

namespace DigisoftPortal.Model;

public class UserAddress
{
    public int UserAddressId { get; set; }
  
    public string? Address1 { get; set; }
    public string? Address2 { get; set; }
    
    public string? Country { get; set; }
   
    public int StateId { get; set; }
  
    public string? City { get; set; }
 
    public string? ZipCode { get; set; }
    public bool IsPermanent { get; set; }
}