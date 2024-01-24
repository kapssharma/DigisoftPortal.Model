using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Digisoft.Portal.Model.Models.Response;

using DigisoftPortal.Model;
using DigisoftPortal.Model.Models.Request;
using DigisoftPortal.Model.Models.Response;

namespace Digisoft.Portal.Model.ViewModels
{
    public class VMForLead
    {
        public VMForLead() 
        { 
            HumanResourcesLeads=new HumanResourcesLeads();
            HumanResourceSource=new List<HumanResourceSource>();
            Streams=new List<Streams>();
            Experience=new List<Experience>();
            SkillSet=new List<SkillSet>();
            Designation=new List<DigisoftPortal.Model.Models.Response.Designation>();
           Roles=new List<Roles>();
            Modal=new Modal();
        }
        public HumanResourcesLeads? HumanResourcesLeads { get; set; }
        public List<HumanResourceSource>? HumanResourceSource { get; set;}
        public List<Streams>? Streams { get; set; }
        public List<Experience>? Experience { get; set; }
        public List<SkillSet>? SkillSet { get; set; }
        public List<DigisoftPortal.Model.Models.Response.Designation>? Designation { get; set; }
        public List<Roles>? Roles { get; set; }
        public Modal? Modal { get; set; }
    }
}
