using DigisoftPortal.Model.Models.Shared;

namespace DigisoftPortal.Model.Models.Response;

public class ClientResponse
{
    public Pagination Pagination { get; set; }
    public List<Client>? Client { get; set; }
}
