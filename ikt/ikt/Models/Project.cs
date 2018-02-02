using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ikt.Models
{
    public partial class Project
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int? SubjectID { get; set; }
        public virtual Subject Subject { get; set; }
        public int? ClassID { get; set; }
        public virtual Class Class { get; set; }
        public int Grade { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
        public string PDF { get; set; }
    }
}