using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digisoft.Portal.Model.Models.Response
{
    public class Streams
    {
       public int ID {get; set;}  
       public string Name {get; set;}  
       public DateTime CreatedBy {get; set;}  
       public DateTime CreatedOn {get; set;}  
       public bool IsActive {get; set;}
    }
}
