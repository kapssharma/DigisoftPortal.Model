using DigisoftPortal.Model.Models.Shared;

namespace DigisoftPortal.Model.Models.Response;

public class WiFiResponse
{
    public Pagination Pagination { get; set; }
    public List<WiFi>? WiFi { get; set; }
}
