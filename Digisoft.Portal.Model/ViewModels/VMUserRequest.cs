using DigisoftPortal.Model.Models.Response;
namespace Digisoft.Portal.Model.ViewModels;
public class VMUserRequest
{
    public VMUserRequest()
    {
        UserRequest = new UserRequest();
        SkillSet = new List<SkillSet>();
        Designation = new List<Designation>();
        Roles = new List<Roles>();
    }
    public UserRequest? UserRequest { get; set; }
    public List<SkillSet>? SkillSet { get; set; }
    public List<Designation>? Designation { get; set; }
    public List<Roles>? Roles { get; set; }
    public List<Questions>? Questions { get; set; }
    public Modal? Modal { get; set; }
}
