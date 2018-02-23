using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ikt.Models;
using ikt.ViewModels;
using ikt.DAL;
using System.Data.Entity;
using PagedList;

namespace ikt.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private iktContext db = new iktContext();
        public ActionResult Index(string search, int? subjectID, string sortBy, int? page)
        {
            SearchIndexViewModel viewModel = new SearchIndexViewModel();
            var projects = db.Projects.Include(p => p.Subject);
            var ikts = db.Ikts.AsQueryable();
            var iktStaff = db.IktStaffs.AsQueryable();

            ViewBag.SubjectID = new SelectList(db.Subjects.OrderBy(s => s.Name), "ID", "Name");

            if (!string.IsNullOrEmpty(search))
            {
                projects = projects.Where(p => p.Name.Contains(search) ||
                p.Subject.Name.Contains(search));

                ikts = ikts.Where(i => i.Name.Contains(search) ||
                i.CreatedBy.Contains(search) ||
                i.UpdatedBy.Contains(search)
                );
                /*
                iktStaff = iktStaff.Where(s => s.Staff.Username.Contains(search) ||
                s.Staff.FirstName.Contains(search) ||
                s.Staff.LastName.Contains(search)
                );
                */
                viewModel.Search = search;
            }

            if (subjectID.HasValue)
            {
                projects = projects.Where(p => p.SubjectID == subjectID);
                ikts = ikts.Where(i => i.Name == "");
            }
            
            if (page > ((projects.Count() + ikts.Count()) / Constants.ItemsPerPage))
            {
                page = (int)Math.Ceiling((projects.Count() + ikts.Count()) / (float)Constants.ItemsPerPage);
            }
            int currentPage = (page ?? 1);
            
            List<Project> pList = projects.ToList();
            List<Ikt> iList = ikts.ToList();

            List<SearchItem> searchItems = new List<SearchItem>();
            for (int i = 0; i < pList.Count; i++)
            {
                searchItems.Add(new SearchItem {
                    ItemID = pList[i].ID,
                    Name = pList[i].Name,
                    Grade = pList[i].Grade,
                    Description = pList[i].Description,
                    CreatedDate = pList[i].CreatedDate,
                    Type = "Project"
                });
            }
            for (int i = 0; i < iList.Count; i++)
            {
                searchItems.Add(new SearchItem
                {
                    ItemID = iList[i].ID,
                    Name = iList[i].Name,
                    Description = iList[i].Description,
                    Comment = iList[i].Comment,
                    CreatedDate = iList[i].CreatedDate,
                    Type = "Ikt"
                });
            }

            switch (sortBy)
            {
                case "nameAZ":
                    searchItems = searchItems.OrderBy(s => s.Name).ToList();
                    break;
                case "nameZA":
                    searchItems = searchItems.OrderByDescending(s => s.Name).ToList();
                    break;
                case "dateNew":
                    searchItems = searchItems.OrderByDescending(s => s.CreatedDate).ToList();
                    break;
                case "dateOld":
                    searchItems = searchItems.OrderBy(s => s.CreatedDate).ToList();
                    break;
            }

            viewModel.SubjectID = subjectID;
            viewModel.SortBy = sortBy;
            viewModel.Sort = new Dictionary<string, string>
            {
                {"Namn: A-Ö", "nameAZ" },
                {"Namn: Ö-A", "nameZA" },
                {"Datum skapat: Nyast först", "dateNew" },
                {"Datum skapat: Äldst först", "dateOld" },
            };

            viewModel.SearchResult = searchItems.ToPagedList(currentPage, Constants.ItemsPerPage);

            return View(viewModel);
        }
    }
}