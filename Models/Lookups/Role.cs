using System.ComponentModel.DataAnnotations;

namespace DigisoftPortal.Model;

public class Role : BaseEntity
{
    [Required]
    [DataType("nvarchar(50)")]
    public string Name { get; set; }
    //navigation
    public virtual ICollection<UserRoles> Users { get; set; }
}