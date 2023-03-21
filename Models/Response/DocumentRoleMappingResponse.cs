using DigisoftPortal.Model.Models.Shared;

namespace DigisoftPortal.Model.Models.Response;

public class DocumentRoleMappingResponse
{
    public Pagination Pagination { get; set; }
    public List<DocumentRoleMapping>? DocumentRoleMappings { get; set; }
}
