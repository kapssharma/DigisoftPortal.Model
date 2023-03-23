namespace DigisoftPortal.Model.Models.Response;

public class Hirings
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Remark { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime ClosingDate { get; set; }
    public int CandidateRequireds { get; set; }
    public decimal MinPackage { get; set; }
    public decimal MaxPackage { get; set; }
    public int HiredSoFar { get; set; }
    public DateTime? CreatedOn { get; set; }
    public bool IsActive { get; set; }
    public string? SkillSet { get; set; }
    public int Experience { get; set; }
}
