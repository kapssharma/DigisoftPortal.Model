using System.ComponentModel.DataAnnotations;

namespace DigisoftPortal.Model;

public class Stream : BaseEntity
{
    [Required]
    [DataType("nvarchar(50)")]
    public string? Name { get; set; }
   // public virtual ICollection<Users> Users { get; set; }
}