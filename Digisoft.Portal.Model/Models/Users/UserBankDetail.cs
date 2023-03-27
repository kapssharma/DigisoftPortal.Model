using System.ComponentModel.DataAnnotations;

namespace DigisoftPortal.Model;

public class UserBankDetail
{
    [DataType("nvarchar(20)")]
   
    public string? AccountNo { get; set; }
    [DataType("nvarchar(100)")]
    
    public string? Name { get; set; }
    [DataType("nvarchar(100)")]
   
    public string? BankName { get; set; }
    [DataType("nvarchar(20)")]
   
    public string? IFSCCode { get; set; }
    [DataType("nvarchar(200)")]
  
    public string? BranchAddress { get; set; }
}