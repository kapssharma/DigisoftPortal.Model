namespace DigisoftPortal.Model.Models.Response;

public class Announcement
{
    public int Id { get; set; }
    public string? Description { get; set; }
    public DateTime? EffectiveTo { get; set; }
    public bool Notified { get; set; }
}
