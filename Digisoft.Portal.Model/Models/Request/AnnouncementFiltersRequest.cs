using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digisoft.Portal.Model.Models.Request
{
    public class AnnouncementFiltersRequest
    {
        public string? Description { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime EffectiveTo { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? EffectiveFrom { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime CreatedOn { get; set; }
        public bool Notified { get; set; }
        public int PageNo { get; set; } = 1;
        public int PageSize { get; set; } = 10;
        public string? SortColumn { get; set; } = "";
        public string? SortOrder { get; set; } = "";
        public bool IsActive { get; set; } = true;
    }
}
