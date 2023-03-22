using DigisoftPortal.Model.Models.Shared;

namespace DigisoftPortal.Model.Models.Response;

public class HumanResourcesLeadsResponse
{
    public Pagination Pagination { get; set; }
    public List<HRLead>? HRLead { get; set; }
}
