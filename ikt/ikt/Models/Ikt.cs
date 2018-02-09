using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ikt.Models
{
    public partial class Ikt
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Comment { get; set; }
        public string Link { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedBy { get; set; } = "";
    }
}