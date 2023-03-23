namespace DigisoftPortal.Model.Models.BiddingAccounts;

public class BiddingAccounts
{
    public string? SalesSource { get; set; }
    public string? UserName { get; set; }
    public string? Email { get; set; }
    public string? Password { get; set; }
    public decimal ProfileRate { get; set; }
    public decimal ExperienceInYY { get; set; }
    public decimal ExperienceInMM { get; set; }
    public string? ProfileImage { get; set; }
    public decimal AccountBalance { get; set; }
    public bool UnderAgency { get; set; }
}
