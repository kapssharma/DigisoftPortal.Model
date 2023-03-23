using System.ComponentModel.DataAnnotations;

namespace DigisoftPortal.Model;

public class Country : BaseEntity
{
    [Required]
    [DataType("nvarchar(100)")]
    public string? Name { get; set; }
    [Required]
    [DataType("nvarchar(2)")]
    public string? Code { get; set; }
    [Required]
    [DataType("nvarchar(3)")]
    public string? Code3 { get; set; }
    [Required]
    [DataType("nvarchar(10)")]
    public string? Number { get; set; }

    //navigation
    public virtual ICollection<State>? States { get; set; }

}
