using DigisoftPortal.Model.Models.Shared;

namespace DigisoftPortal.Model.Models.BiddingAccounts;

public class BiddingAccountsResponse
{
    public Pagination Pagination { get; set; }
    public List<BiddingAccounts>? BiddingAccounts { get; set; }
}
