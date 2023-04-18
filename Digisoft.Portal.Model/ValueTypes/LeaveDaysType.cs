
using System.ComponentModel.DataAnnotations;

namespace DigisoftPortal.Model.ValueTypes;

public class LeaveDaysType
{
    public int Id { get; set; }
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    public DateTime? From { get; set; }

    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    public DateTime? To { get; set; }
    public int LeaveTypeId { get; set; }
    
    
   
}
