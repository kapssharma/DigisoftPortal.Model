using System.ComponentModel.DataAnnotations;
namespace DigisoftPortal.Model.Models;

public class LeaveDays : GenericColumns
{

    [Required]
    public DateTime From { get; set; }
   
    [Required]
    public DateTime To { get; set; }
    public int LeaveTypeId { get; set; }
    
    //public string LeaveType { get; set; }
}