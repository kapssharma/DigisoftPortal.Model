using System.ComponentModel.DataAnnotations;

namespace DigisoftPortal.Model;

public class UserDocuments
{
    public int ID { get; set; }
    public int DocumentId { get; set; }
  
    public string? DocumentName { get; set; }
    public string? Link { get; set; }
    public int Size { get; set; }
}