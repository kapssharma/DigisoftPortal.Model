using System.ComponentModel.DataAnnotations;

namespace DigisoftPortal.Model.Models.TeamMembers;

public class TeamMembersRequest : GenericColumns
{
    [Required]
    public int MemberID { get; set; }
    [Required]
    public int TeamID { get; set; }
}
