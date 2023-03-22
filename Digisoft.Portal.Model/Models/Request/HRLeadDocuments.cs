using System.ComponentModel.DataAnnotations;

namespace DigisoftPortal.Model.Models.Request;

public class HRLeadDocuments
{
    public int HRLeadDocumentsId { get; set; }
    public int DocumentID { get; set; }
    public int LeadID { get; set; }
    [DataType("varchar(160)")]
    [Required]
    public string? DocumentName { get; set; }

    [DataType("varchar(500)")]
    public string? Link { get; set; }
    public int Size { get; set; }

}
