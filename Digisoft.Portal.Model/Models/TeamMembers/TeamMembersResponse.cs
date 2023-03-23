using DigisoftPortal.Model.Models.Shared;

namespace DigisoftPortal.Model.Models.TeamMembers;

public class TeamMembersResponse
{
    public Pagination? Pagination { get; set; }
    public List<TeamMembers>? TeamMembers { get; set; }
}
