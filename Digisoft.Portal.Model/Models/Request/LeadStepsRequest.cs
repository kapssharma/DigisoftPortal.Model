using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigisoftPortal.Model;


public class LeadStepsRequest
{
    [Required]
    public int LeadTypeId { get; set; }
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
