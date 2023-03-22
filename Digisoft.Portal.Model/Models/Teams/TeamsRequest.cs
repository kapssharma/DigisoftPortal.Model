using System.ComponentModel.DataAnnotations;

namespace DigisoftPortal.Model.Models.Teams;

public class TeamsRequest : GenericColumns
{
    [Required]
    public string Name { get; set; }
    [Required]
    public int TeamLeadID { get; set; }
    [Required]
    public int TeamManagerID { get; set; }

}