using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ikt.Models
{
    public class SearchItem
    {
        public int ItemID { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Comment { get; set; }
        public int Grade { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}