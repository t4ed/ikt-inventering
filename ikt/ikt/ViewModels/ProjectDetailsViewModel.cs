using ikt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ikt.ViewModels
{
    public class ProjectDetailsViewModel
    {
        public Project Project { get; set; }
        public List<ProjectStaff> ProjectStaff { get; set; }
        public List<ProjectClass> ProjectClass { get; set; }
    }
}