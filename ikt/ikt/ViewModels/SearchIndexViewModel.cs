using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ikt.Models;
using PagedList;

namespace ikt.ViewModels
{
    public class SearchIndexViewModel
    {
        public IPagedList<Project> Projects { get; set; }
        public IPagedList<Ikt> IKTs { get; set; }
        public string Search { get; set; }
    }
}