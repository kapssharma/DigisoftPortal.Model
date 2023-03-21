using DigisoftPortal.Model.Models.Request;
namespace DigisoftPortal.Model.Models.Response;

public class HumanResourcesLead
{

    public List<HumanResourcesLeads>? HumanResourcesLeads { get; set; }
    public List<HRLeadTechnicalInformation>? HRLeadTechnicalInformation { get; set; }
    public List<HRLeadDocuments>? HRLeadDocuments { get; set; }
}
