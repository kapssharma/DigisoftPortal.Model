using DigisoftPortal.Model.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digisoft.Portal.Model.ViewModels
{
    public class VMForUserList
    {
        public VMForUserList()
        {
            User = new List<User>();
        }
        public List<User>? User { get; set; }
        public string? UserID { get; set; }
    }
}
