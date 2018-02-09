using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ikt.Models
{
    public partial class Subject
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedBy { get; set; } = "";
    }
}