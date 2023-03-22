using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigisoftPortal.Model.Models.Response;

public class DocumentRoleMapping
{
    public int Id { get; set; }

    [Required]
    public int DocumentID { get; set; }

    [Required]
    public int RoleID { get; set; }
}
