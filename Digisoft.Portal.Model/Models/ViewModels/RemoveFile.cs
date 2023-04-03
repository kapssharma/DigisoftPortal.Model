using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digisoft.Portal.Model.Models.ViewModels
{
    public class RemoveFile
    {
        public string? FileName { get; set; }
        public bool IsRemoved { get; set; }
        public string? Message { get; set; }
    }
}
