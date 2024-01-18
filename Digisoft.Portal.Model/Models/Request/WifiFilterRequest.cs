using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digisoft.Portal.Model.Models.Request
{
    public class WifiFilterRequest
    {
        //public string? Name { get; set; }
        //public string? ProviderCompany { get; set; }
        //public string? StaticIpAddress { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? updateOn { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? CreatedOn { get; set; }
       
        public string? SearchValue { get; set; } = "";
        public string? SearchColumn { get; set; } = "";
        public int PageNo { get; set; } = 1;
        public int PageSize { get; set; } = 10;
        public string? SortColumn { get; set; } = "";
        public string? SortOrder { get; set; } = "";
        public bool IsActive { get; set; } = true;
    }
}
