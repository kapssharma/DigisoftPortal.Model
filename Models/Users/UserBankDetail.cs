using System.ComponentModel.DataAnnotations;

namespace DigisoftPortal.Model;

public class UserBankDetail
{
    [DataType("nvarchar(20)")]
    [Required]
    public string? AccountNo { get; set; }
    [DataType("nvarchar(100)")]
    [Required]
    public string? Name { get; set; }
    [DataType("nvarchar(100)")]
    [Required]
    public string? BankName { get; set; }
    [DataType("nvarchar(20)")]
    [Required]
    public string? IFSCCode { get; set; }
    [DataType("nvarchar(200)")]
    [Required]
    public string? BranchAddress { get; set; }
}