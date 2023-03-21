using System.ComponentModel.DataAnnotations;

namespace DigisoftPortal.Model.Models.Request;

public class DocumentRoleMappingRequest
{
    [Required]
    public int DocumentID { get; set; }

    [Required]
    public int RoleID { get; set; }
}
