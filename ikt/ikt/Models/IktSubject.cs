using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ikt.Models
{
    public partial class IktSubject
    {
        public int ID { get; set; }
        public int? SubjectID { get; set; }
        public virtual Subject Subject { get; set; }
        public int? IktID { get; set; }
        public virtual Ikt Ikt { get; set; }
    }
}