using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ikt.Models
{
    public class IktStaff
    {
        public int ID { get; set; }
        public int StaffID { get; set; }
        public virtual Staff Staff { get; set; }
        public int IktID { get; set; }
        public virtual Ikt Ikt { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedBy { get; set; } = "";
    }
}