namespace Digisoft.Portal.Model;

public class PackageList
{
    public List<Package> GetPackage()
    {
        List<Package> package = new List<Package>();
        package.Add(new Package { Id = 1, Name = "1.0" });
        package.Add(new Package { Id = 2, Name = "2.0" });
        package.Add(new Package { Id = 3, Name = "3.0" });
        package.Add(new Package { Id = 4, Name = "4.0" });
        package.Add(new Package { Id = 5, Name = "5.0" });
        package.Add(new Package { Id = 6, Name = "6.0" });
        package.Add(new Package { Id = 7, Name = "7.0" });
        package.Add(new Package { Id = 8, Name = "8.0" });
        package.Add(new Package { Id = 9, Name = "9.0" });
        package.Add(new Package { Id = 10, Name = "10.0" });
        return package;
    }
}
