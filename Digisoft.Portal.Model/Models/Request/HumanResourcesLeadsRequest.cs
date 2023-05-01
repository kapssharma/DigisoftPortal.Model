using System.ComponentModel.DataAnnotations;

namespace DigisoftPortal.Model.Models.Request;

public class HumanResourcesLeadsRequest:GenericColumns
{
    [DataType("varchar(50)")]
    [Required]
    public string? FirstName { get; set; }

    [DataType("varchar(50)")]
    public string? MiddleName { get; set; }

    [DataType("varchar(50)")]
    [Required]
    public string? LastName { get; set; }

    [DataType("varchar(50)")]
    [Required]
    public string? PhoneNumber { get; set; }

    [DataType("varchar(50)")]
    public string? AlternatePhoneNumber { get; set; }

    [DataType("varchar(50)")]
    [Required]
    public string? Email { get; set; }
    public int LeadSourceID { get; set; }

    public int StreamID { get; set; }
    public int ReferedByID { get; set; }

    [DataType("varchar(600)")]
    public string? Image { get; set; }

    [DataType("varchar(150)")]
    [Required]
    public string? CurrentCompany { get; set; }
    [DataType("varchar(500)")]
    public string? ChangeReason { get; set; }
    public decimal CTC { get; set; }
    public decimal ECTC { get; set; }

    public int NoticePeroid { get; set; }
    public bool IsNegotiable { get; set; }
    public int UserID { get; set; }
    [DataType("varchar(50)")]
    public string? Offered { get; set; }
    public int RoleID { get; set; }
    [DataType("varchar(400)")]
    public string? Remark { get; set; }
    public int DesignationID { get; set; }

    public List<HRLeadTechnicalInformation>? HRLeadTechnicalInformation { get; set; }
    public List<HRLeadDocuments>? HRLeadDocuments { get; set; }

}
