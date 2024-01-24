using Digisoft.Portal.Model.Models.Response;

using DigisoftPortal.Model.Models.Shared;

namespace DigisoftPortal.Model.Models.Response;

public class StreamResponse
{
    public Pagination? Pagination { get; set; }

    public List<Streams>? streams { get; set; }
}