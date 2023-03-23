

using DigisoftPortal.Model.Models.Shared;

namespace DigisoftPortal.Model.Models.Response;

public class ProjectResponse
{
    public Pagination? Pagination { get; set; }
    public List<Project>? Projects { get; set; }
}
