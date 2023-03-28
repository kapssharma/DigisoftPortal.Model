namespace DigisoftPortal.Model.Models.Response;

public class WiFi
{
    public int Id { get; set; }
    public string? Name { get; set; }

    public string? Password { get; set; }

    public string? ProviderCompany { get; set; }

    public bool StaticIP { get; set; }

    public string? StaticIPAddress { get; set; }
    public DateTime CreatedOn { get; set; }
}
