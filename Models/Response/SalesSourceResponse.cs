using DigisoftPortal.Model.Models.Shared;

namespace DigisoftPortal.Model.Models.Response;

public class SalesSourceResponse
{
    public Pagination Pagination { get; set; }
    public List<SaleSource>? SalesSources { get; set; }
}
