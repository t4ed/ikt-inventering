using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ikt.Models
{
    public class ProjectClass
    {
        public int ID { get; set; }
        public int? ClassID { get; set; }
        public virtual Class Class { get; set; }
        public int? ProjectID { get; set; }
        public virtual Project Project { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedBy { get; set; } = "";
    }
}