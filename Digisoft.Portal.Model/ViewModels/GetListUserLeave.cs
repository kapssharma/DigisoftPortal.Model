using DigisoftPortal.Model.Models.Shared;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digisoft.Portal.Model.ViewModels
{
    public class GetListUserLeave
    {
        public GetListUserLeave()
        {
            Pagination = new Pagination();
            VMForUserLeave = new List<VMForUserLeave>();
        }
        public Pagination? Pagination { get; set; }
        public List<VMForUserLeave>? VMForUserLeave { get; set; }
    }
}
