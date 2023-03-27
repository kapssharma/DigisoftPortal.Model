namespace DigisoftPortal.Model.Models.Response;

public class WiFi : GenericColumns
{
    public string? Name { get; set; }

    public string? Password { get; set; }

    public string? ProviderCompany { get; set; }

    public bool StaticIP { get; set; }

    public string? StaticIPAddress { get; set; }
}
