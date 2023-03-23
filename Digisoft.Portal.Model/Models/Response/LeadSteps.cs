using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigisoftPortal.Model.Models.Response;

public class LeadSteps
{    
    public int Id { get; set; }
    public int LeadTypeID { get; set; }
    [Required]
    [DataType("nvarchar(100)")]
    public string? Name { get; set; }
    [DataType("nvarchar(50)")]
    public string? BGColor { get; set; }
    [DataType("nvarchar(50)")]
    public string? Color { get; set; }
    public bool IsReasonRequired { get; set; }
    [DataType("nvarchar(2500)")]
    public string? MessageHTML { get; set; }
    [DataType("nvarchar(500)")]
    public string? Message { get; set; }
}
