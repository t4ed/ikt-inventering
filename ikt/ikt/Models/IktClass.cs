using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ikt.Models
{
    public partial class IktClass
    {
        public int ID { get; set; }
        public int? ClassID { get; set; }
        public virtual Class Class { get; set; }
        public int? IktID { get; set; }
        public virtual Ikt Ikt { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedBy { get; set; } = "";
    }
}