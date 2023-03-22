namespace DigisoftPortal.Model.Models.Response;

public class Portals
{
    public int Id { get; set; }

    public string? Title { get; set; }
    public string? ContactPerson { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }
    public bool PaidService { get; set; }
    public bool Purchased { get; set; }
    public DateTime ExpiredAt { get; set; }
    public string? Remark { get; set; }
}
