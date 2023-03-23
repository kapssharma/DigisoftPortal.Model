using System.ComponentModel.DataAnnotations;

namespace DigisoftPortal.Model.Models.BiddingAccounts;

public class BiddingAccountsRequest : GenericColumns
{
    [Required]
    public int SalesSourceID { get; set; }
    [Required]
    public string? UserName { get; set; }
    [Required]
    [EmailAddress]
    public string? Email { get; set; }
    [Required]
    public string? Password { get; set; }
    [Required]
    public decimal ProfileRate { get; set; }
    [Required]
    public decimal ExperienceInYY { get; set; }
    [Required]
    public decimal ExperienceInMM { get; set; }
    [Required]
    public string? ProfileImage { get; set; }
    [Required]
    public decimal AccountBalance { get; set; }
    [Required]
    public bool UnderAgency { get; set; }
}
