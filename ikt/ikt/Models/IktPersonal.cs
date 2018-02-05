﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ikt.Models
{
    public partial class IktPersonal
    {
        public int ID { get; set; }
        public string Personal { get; set; }
        public int? IktID { get; set; }
        public virtual ikt Ikt { get; set; }
    }
}