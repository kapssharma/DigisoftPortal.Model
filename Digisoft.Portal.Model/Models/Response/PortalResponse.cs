using DigisoftPortal.Model.Models.Shared;

namespace DigisoftPortal.Model.Models.Response;

public class PortalResponse
{
    public Pagination? Pagination { get; set; }
    public List<Portals>? PortalResponses { get; set; }
}
