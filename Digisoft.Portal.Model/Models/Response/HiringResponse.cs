
using DigisoftPortal.Model.Models.Shared;

namespace DigisoftPortal.Model.Models.Response;

public class HiringResponse
{
    public Pagination? Pagination { get; set; }
    public List<Hirings>? Hirings { get; set; }
}
