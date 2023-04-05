using DigisoftPortal.Model.Models.Response;
namespace Digisoft.Portal.Model.ViewModels;


public class VMForHiring
{
    public VMForHiring()
    {
        Hiring = new Hiring();
        SkillSet = new List<SkillSet>();
        Experience = new List<Experience>();
        Package = new List<Package>();
    }
    public Hiring? Hiring { get; set; }
    public List<SkillSet>? SkillSet { get; set; }
    public List<Experience> Experience { get; set; }
    public List<Package> Package { get; set; }
}

