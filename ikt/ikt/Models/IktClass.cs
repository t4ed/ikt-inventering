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
    }
}