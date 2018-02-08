﻿using System;
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
        public int Grade { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
        public string PDF { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedBy { get; set; } = "";
    }
}