using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digisoft.Portal.Model.ViewModels
{
    public class SearchEmployeeByFilter
    {
        public string? FullName { get; set; }
        public DateTime? DOJ { get; set; }
        public DateTime? LoginStart { get; set; }
        public DateTime? LoginEnd { get; set; }
        public DateTime? DOB { get; set; }
        public DateTime? Status { get; set; }
    }
}
