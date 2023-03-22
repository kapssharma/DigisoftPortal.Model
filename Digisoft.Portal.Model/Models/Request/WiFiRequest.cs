
using System.ComponentModel.DataAnnotations;

namespace DigisoftPortal.Model.Models.Request;

public class WiFiRequest:GenericColumns
{
    [DataType("varchar(150)")]
    [Required]
    public string? Name { get; set; }

    [DataType("varchar(150)")]
    [Required]
    public string? Password { get; set; }

    [DataType("varchar(200)")]
    public string? ProviderCompany { get; set; }
   
    public bool StaticIP { get; set; }

    [DataType("varchar(200)")]
    public string? StaticIPAddress { get; set; }

}
