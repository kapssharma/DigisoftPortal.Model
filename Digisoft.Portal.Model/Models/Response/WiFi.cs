using System.ComponentModel.DataAnnotations;

namespace DigisoftPortal.Model.Models.Response;

public class WiFi
{
    public int Id { get; set; }

    [DataType("varchar(150)")]
    [Required(ErrorMessage = "WiFi Name is Required")]
    public string? Name { get; set; }

    [DataType("varchar(150)")]
    [Required(ErrorMessage = "WiFi Name is Required")]
    public string? Password { get; set; }

    [DataType("varchar(200)")]
    [Required(ErrorMessage = "WiFi Provider Company Name is Required")]
    public string? ProviderCompany { get; set; }

    public bool StaticIP { get; set; }

    [DataType("varchar(200)")]
    [Required(ErrorMessage = "WiFi IP Address is Required")]
    public string? StaticIPAddress { get; set; }
    public DateTime CreatedOn { get; set; }
}
