using System.ComponentModel.DataAnnotations;

namespace DigisoftPortal.Model.Models.Response;

public class Project
{
    public int Id { get; set; }

    [Required]
    [DataType("VARCHAR(50)")]
    public string? Name { get; set; }

    public int SalesSourceID { get; set; }

    public int ClientID { get; set; }

    public DateTime HiredAt { get; set; }

    public bool IsFixedPrice { get; set; }

    [DataType("Decimal(18,0)")]
    public decimal AmountOrHourlyRate { get; set; }
}
