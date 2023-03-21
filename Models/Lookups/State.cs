using System.ComponentModel.DataAnnotations;

namespace DigisoftPortal.Model;

public class State : BaseEntity
{
    [Required]
    [DataType("nvarchar(50)")]
    public string Name { get; set; }
    [Required]
    public int CountryId { get; set; }

    //navigation
    public virtual Country Country { get; set; }
}