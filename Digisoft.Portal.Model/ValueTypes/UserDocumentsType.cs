using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigisoftPortal.Model
{
    public class UserDocumentsType
    {
        public int Id { get; set; }
        public int DocumentID { get; set; }
        public string? DocumentName { get; set; }
        public string? Link { get; set; }
        public int Size { get; set; }
    }
}
