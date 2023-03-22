using System.ComponentModel.DataAnnotations;

namespace DigisoftPortal.Model.Models.Response;

public class Announcements
{
    public int Id { get; set; }
    [Required(ErrorMessage = "Please Enter Description")]
    public string? Description { get; set; }
    [Required(ErrorMessage = "Please Enter Date")]

    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    public DateTime EffectiveTo { get; set; }

    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    public DateTime CreatedOn { get; set; }

    public bool Notified { get; set; }
}
