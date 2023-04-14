using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digisoft.Portal.Model.ViewModels
{
    public class VMForUserLeave
    {
        public VMForUserLeave()
        {
            UserLeave = new UserLeave();
            UserLeaveDays = new List<UserLeaveDays>();
        }
        public UserLeave? UserLeave { get; set; }
        public List<UserLeaveDays>? UserLeaveDays { get; set; }
    }
}
