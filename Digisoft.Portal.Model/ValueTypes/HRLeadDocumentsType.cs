using System.ComponentModel.DataAnnotations;

namespace DigisoftPortal.Model.ValueTypes;

public class HRLeadDocumentsType
{
    public int Id { get; set; }
    public int DocumentID { get; set; }
    public int LeadID { get; set; }
    [DataType("varchar(160)")]
    public string? DocumentName { get; set; }

    [DataType("varchar(500)")]
    public string? Link { get; set; }
    public int Size { get; set; }
}
