using System.ComponentModel.DataAnnotations;

namespace DigisoftPortal.Model;

public class Designation : BaseEntity
{
    [Required]
    [DataType("nvarchar(50)")]
    public string? Name { get; set; }
   // public virtual ICollection<User> Users { get; set; }
}