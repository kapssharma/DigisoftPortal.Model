namespace Digisoft.Portal.Model;

public class ExperienceList
{
    public List<Experience> GetExperience()
    {
        List<Experience> experience = new List<Experience>();
        experience.Add(new Experience { ID = 1, Name = "1" });
        experience.Add(new Experience { ID = 2, Name = "2" });
        experience.Add(new Experience { ID = 3, Name = "3" });
        experience.Add(new Experience { ID = 4, Name = "4" });
        experience.Add(new Experience { ID = 5, Name = "5" });
        experience.Add(new Experience { ID = 6, Name = "6" });
        experience.Add(new Experience { ID = 7, Name = "7" });
        experience.Add(new Experience { ID = 8, Name = "8" });
        experience.Add(new Experience { ID = 9, Name = "9" });
        experience.Add(new Experience { ID = 10, Name = "10" });
        return experience;
    }
}

