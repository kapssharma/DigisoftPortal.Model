using System;
using System.Collections.Generic;

namespace Digisoft.Portal.Web.Models.Search
{
    public class DataTableAjaxPostModel
    {
        // properties are not capital due to json mapping
        public int Draw { get; set; }
        public int Start { get; set; }
        public int Length { get; set; }
        public List<Column> Columns { get; set; }
        public Search Search { get; set; }
        public List<Order> Order { get; set; }
        public int? InterviewStatusId { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; } 
        public int AssignedToId { get; set; }
        
    }

    public class Column
    {
        public Data Data { get; set; }
        public string Name { get; set; }
        public bool Searchable { get; set; }
        public bool Orderable { get; set; }
        public Search Search { get; set; }
    }

    public class Search
    {
        public string Value { get; set; }
        public string Regex { get; set; }
    }

    public class Order
    {
        public int Column { get; set; }
        public string Dir { get; set; }
    }
    public class Data
    {
        public string _ { get; set; }
        public string Sort { get; set; }
    }
}
