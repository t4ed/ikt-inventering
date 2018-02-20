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
        public List<Project> Projects { get; set; }
        public List<Ikt> IKTs { get; set; }
        public IPagedList<SearchItem> SearchResult { get; set; }
        public string Search { get; set; }
    }
}