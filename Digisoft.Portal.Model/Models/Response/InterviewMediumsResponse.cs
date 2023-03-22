using DigisoftPortal.Model.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigisoftPortal.Model.Models.Response;

public class InterviewMediumsResponse
{
    public Pagination Pagination { get; set; }
    public List<InterviewMediums>? InterviewMediums { get; set; }
}
