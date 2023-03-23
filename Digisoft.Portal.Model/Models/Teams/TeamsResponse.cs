using DigisoftPortal.Model.Models.Shared;

namespace DigisoftPortal.Model.Models.Teams;

public class TeamsResponse
{
    public Pagination? Pagination { get; set; }
    public List<Teams>? Teams { get; set; }
}
