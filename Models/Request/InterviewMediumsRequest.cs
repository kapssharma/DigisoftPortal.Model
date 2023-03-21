using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigisoftPortal.Model;

public class InterviewMediumsRequest
{
    [Required]
    [StringLength(20)]
    public string Description { get; set; }
}
