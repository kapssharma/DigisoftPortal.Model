using System.ComponentModel.DataAnnotations;
namespace DigisoftPortal.Model.Models;

public class LeaveDays : GenericColumns
{

    [Required]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    public DateTime? From { get; set; }

    [Required]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    public DateTime? To { get; set; }
    public int LeaveTypeId { get; set; }

    //public string LeaveType { get; set; }
}