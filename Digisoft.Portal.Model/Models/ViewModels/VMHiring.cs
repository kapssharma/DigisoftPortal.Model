using DigisoftPortal.Model.Models.Response;
namespace Digisoft.Portal.Model.Models.ViewModels;


public class VMForHiring
{
    public VMForHiring(Hiring? hiring)
    {
        Hiring = hiring;
        SkillSet = new List<SkillSet>();
    }
    public Hiring? Hiring { get; set; }
    public List<SkillSet>? SkillSet { get; set; }
}

