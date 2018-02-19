using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ikt.Models;
using ikt.ViewModels;
using ikt.DAL;
using System.Data.Entity;

namespace ikt.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private iktContext db = new iktContext();
        public ActionResult Index(string search)
        {
            SearchIndexViewModel viewModel = new SearchIndexViewModel();
            var projects = db.Projects.Include(p => p.Subject);
            var ikts = db.Ikts.Include(i => i.Name);

            if (!string.IsNullOrEmpty(search))
            {
                projects = projects.Where(p => p.Name.Contains(search) ||
                p.Subject.Name.Contains(search));

                ikts = ikts.Where(i => i.Name.Contains(search) ||
                i.CreatedBy.Contains(search) ||
                i.UpdatedBy.Contains(search));
            }

            return View();
        }
    }
}