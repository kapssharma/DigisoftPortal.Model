namespace DigisoftPortal.Model.ValueTypes;

public class HRLeadTechnicalInformationType
{
    public int Id { get; set; }
    public int LeadID { get; set; }
    public int SkillSetID { get; set; }
    public decimal ExpInYY { get; set; }
    public decimal ExpInMM { get; set; }
    public int DesignationID { get; set; }
}
