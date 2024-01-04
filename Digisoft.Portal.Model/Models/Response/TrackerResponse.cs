using DigisoftPortal.Model.Models.Response;
using DigisoftPortal.Model.Models.Shared;

namespace Digisoft.Portal.Model.Models.Response;

public class TrackerResponse
{
    public Pagination? Pagination { get; set; }
    public List<Tracker>? Tracker { get; set; }
}
