namespace DigisoftPortal.Model.Models.Response;

public class HumanResourcesLeads:GenericColumns
{
    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? MiddleName { get; set; }

    public string? PhoneNumber { get; set; }

    public string? AlternatePhoneNumber { get; set; }

    public string? Email { get; set; }
    public int LeadSourceId { get; set; }

    public int StreamId { get; set; }
    public int ReferedById { get; set; }

    public string? Image { get; set; }

    public string? CurrentCompany { get; set; }
    public string? ChangeReason { get; set; }
    public decimal CTC { get; set; }
    public decimal ECTC { get; set; }

    public int NoticePeroid { get; set; }
    public bool IsNegotiable { get; set; }
    public int UserID { get; set; }
    public string? Offered { get; set; }
    public int RoleId { get; set; }
    public string? Remark { get; set; }
    public List<UserAddress>? UserAddress { get; set; }

    public UserBankDetail? UserBankDetails { get; set; }

    public List<UserTechnicalInformtion>? UserTechnicalInformtions { get; set; }

    public List<UserDocuments>? UserDocuments { get; set; }

    public List<UserCompany>? UserCompany { get; set; }

    public List<UserGetTOKnows>? UserGetTOKnows { get; set; }

}
