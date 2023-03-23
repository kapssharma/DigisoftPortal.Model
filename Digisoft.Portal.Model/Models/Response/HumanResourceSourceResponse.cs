using DigisoftPortal.Model.Models.Shared;

namespace DigisoftPortal.Model.Models.Response;
public class HumanResourceSourceResponse
{
    public Pagination? Pagination { get; set; }
    public List<HumanResourceSource>? humanResourceSources { get; set; }
}