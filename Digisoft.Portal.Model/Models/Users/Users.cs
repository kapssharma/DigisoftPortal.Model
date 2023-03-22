
using DigisoftPortal.Model.Models.Response;

namespace DigisoftPortal.Model;

public class Users
{
    public List<UserList>? UserList { get; set; }
    public List<UserAddress>? UserAddress { get; set; }
    public List<UserBankDetail>? UserBankDetails { get; set; }
    public List<UserTechnicalInformtion>? UserTechnicalInformtions { get; set; }
    public List<UserDocuments>? UserDocuments { get; set; }
    public List<UserCompany>? UserCompany { get; set; }
    public List<UserGetTOKnows>? UserGetTOKnows { get; set; }

}
