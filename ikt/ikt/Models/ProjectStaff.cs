﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ikt.Models
{
    public partial class ProjectStaff
    {
        public int ID { get; set; }
        public int? ProjectID { get; set; }
        public virtual Project Project { get; set; }
        public int? StaffID { get; set; }
        public virtual Staff Staff { get; set; }
    }
}