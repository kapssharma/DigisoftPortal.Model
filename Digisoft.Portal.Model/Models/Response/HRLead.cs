namespace DigisoftPortal.Model.Models.Response;

public class HRLead
{
    public int Id { get; set; }

    public string? FullName { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }
    public string? Source { get; set; }

    public string? Stream { get; set; }
    public DateTime CreatedOn { get; set; }
    public bool Isactive { get; set; }
}
