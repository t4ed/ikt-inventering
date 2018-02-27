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
        public ActionResult Index(string search, int? subjectID, int? ClassID, int? grade, string sortBy, int? page)
        {
            SearchIndexViewModel viewModel = new SearchIndexViewModel();
            var projects = db.Projects.Include(p => p.Subject);
            var classes = db.Classes.Include(p => p.Name); 
            var ikt = db.Ikts.AsQueryable();

            ViewBag.SubjectID = new SelectList(db.Subjects.OrderBy(s => s.Name), "ID", "Name");
            ViewBag.ClassID = new SelectList(db.Classes.OrderBy(s => s.Name), "ID", "Name"); 

            if (!string.IsNullOrEmpty(search))
            {
                projects = projects.Where(p => p.Name.Contains(search) ||
                p.Subject.Name.Contains(search));

                classes = classes.Where(p => p.Name.Contains(search) ||
                p.Name.Contains(search)); 

                /*
                ikt = from i in db.Ikts
                           join s in db.IktStaffs on
                           i.ID equals s.IktID
                           join c in db.IktClasses on
                           i.ID equals c.IktID
                           where
                           s.Staff.FirstName.Contains(search) ||
                           s.Staff.LastName.Contains(search) ||
                           s.Staff.Username.Contains(search) ||
                           c.Class.Name.Contains(search) ||
                           i.Name.Contains(search)
                          select i;
                */

                ikt = 
                    from i in db.Ikts
                    join s in db.IktStaffs on i.ID equals s.IktID into st
                    from s in st.DefaultIfEmpty()
                    join c in db.IktClasses on i.ID equals c.IktID into cl
                    from c in cl.DefaultIfEmpty()
                    where
                    s.Staff.FirstName.Contains(search) ||
                           s.Staff.LastName.Contains(search) ||
                           s.Staff.Username.Contains(search) ||
                           c.Class.Name.Contains(search) ||
                           i.Name.Contains(search)
                    select i;

                ikt = ikt.Distinct();


                viewModel.Search = search;
            }

            if (subjectID.HasValue)
            {
                projects = projects.Where(p => p.SubjectID == subjectID);
                ikt = ikt.Where(i => i.Name == "");
            }

            if (ClassID.HasValue)
            {
                classes = classes.Where(p => p.ID == ClassID);
                ikt = ikt.Where(i => i.Name == "");
            }

            if (grade.HasValue)
            {
                projects = projects.Where(p => p.Grade == grade);
                ikt = ikt.Where(i => i.Name == "");
            }
            
            if (page > ((projects.Count() + ikt.Count()) / Constants.ItemsPerPage))
            {
                page = (int)Math.Ceiling((projects.Count() + ikt.Count()) / (float)Constants.ItemsPerPage);
            }
            int currentPage = (page ?? 1);
            
            List<Project> pList = projects.ToList();
            List<Ikt> iList = ikt.ToList();
            //iList.Concat(iktsForStaff.ToList());
            //Remove duplicate IDs from list.
            //List<Ikt> iList = MergeIKT(ikts.ToList(), iktsForStaff.ToList());

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

            viewModel.Grade = grade;
            viewModel.GradeList = new Dictionary<string, int>
            {
                {"Årskurs 1", 1 },
                {"Årskurs 2", 2 },
                {"Årskurs 3", 3 },
                {"Årskurs 4", 4 },
            };
            viewModel.SubjectID = subjectID;
            viewModel.ClassID = ClassID; 
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

        private List<Ikt> MergeIKT(List<Ikt> listA, List<Ikt> listB)
        {
            List<Ikt> mergedIkt = new List<Ikt>();
            
            foreach (var itemA in listA)
            {
                if (!mergedIkt.Contains(itemA))
                {
                    mergedIkt.Add(itemA);
                }
            }

            foreach (var itemB in listB)
            {
                if (!mergedIkt.Contains(itemB))
                {
                    mergedIkt.Add(itemB);
                }
            }
            return mergedIkt;
        }
    }
}