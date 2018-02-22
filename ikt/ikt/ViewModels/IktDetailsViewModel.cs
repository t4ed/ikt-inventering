using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ikt.Models;

namespace ikt.ViewModels
{
    public class IktDetailsViewModel
    {
        public Ikt Ikt { get; set; }
        public List<IktStaff> IktStaff { get; set; }
        public List<IktClass> IktClass { get; set; }
    }
}