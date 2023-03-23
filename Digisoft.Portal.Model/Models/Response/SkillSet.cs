using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigisoftPortal.Model.Models.Response;

public class SkillSet
{
    public int TotalRows { get; set; }
    public int Id { get; set; }
    [DataType("nvarchar(50)")]
    [Required]
    public string? Name { get; set; }
}
