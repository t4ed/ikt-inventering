using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ikt.DAL;
using ikt.Models;

namespace ikt.Controllers
{
    public class ProjectsController : Controller
    {
        private iktContext db = new iktContext();

        // GET: Projects
        public ActionResult Index()
        {
            var projects = db.Projects.Include(p => p.Subject);
            return View(projects.ToList());
        }

        // GET: Projects/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Project project = db.Projects.Find(id);
            if (project == null)
            {
                return HttpNotFound();
            }
            return View(project);
        }

        // GET: Projects/Create
        public ActionResult Create()
        {
            ViewBag.SubjectID = new SelectList(db.Subjects.OrderBy(s => s.Name), "ID", "Name");
            return View();
        }

        // POST: Projects/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(string Name, string SubjectID, string ClassID, int Grade, string Description, string Date, string CreatedBy)
        {
            Project project = new Project
            {
                Name = Name,
                SubjectID = db.Subjects.Where(s => s.Name == SubjectID).Single().ID,
                Grade = Grade,
                Description = Description,
                Date = Date,
                CreatedDate = DateTime.Now,
                CreatedBy = CreatedBy,
                UpdatedDate = DateTime.Now,
                UpdatedBy = CreatedBy
            };

            if (ModelState.IsValid)
            {
                db.Projects.Add(project);

                db.ProjectClasses.Add(new ProjectClass
                {
                    ClassID = db.Classes.Where(c => c.Name == ClassID).Single().ID,
                    ProjectID = project.ID,
                    CreatedDate = DateTime.Now,
                    CreatedBy = CreatedBy,
                    UpdatedDate = DateTime.Now,
                    UpdatedBy = CreatedBy
                });

                db.ProjectStaffs.Add(new ProjectStaff
                {
                    StaffID = db.Staff.Where(s => s.Username == CreatedBy).Single().ID,
                    ProjectID = project.ID,
                    CreatedDate = DateTime.Now,
                    CreatedBy = CreatedBy,
                    UpdatedDate = DateTime.Now,
                    UpdatedBy = CreatedBy
                });

                db.SaveChanges();
                return RedirectToRoute("Default");
            }
            
            return View(project);
        }

        // GET: Projects/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Project project = db.Projects.Find(id);
            if (project == null)
            {
                return HttpNotFound();
            }
            ViewBag.SubjectID = new SelectList(db.Subjects, "ID", "Name", project.SubjectID);
            return View(project);
        }

        // POST: Projects/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int ID, string Name, int Grade, string SubjectID, string Description, string Date, string CreatedBy, string CreatedDate, string UpdatedBy)
        {
            Project project = new Project
            {
                ID = ID,
                Name = Name,
                SubjectID = db.Subjects.Where(s => s.Name == SubjectID).Single().ID,
                Grade = Grade,
                Description = Description,
                Date = Date,
                CreatedBy = CreatedBy,
                CreatedDate = DateTime.Parse(CreatedDate),
                UpdatedBy = UpdatedBy,
                UpdatedDate = DateTime.Now
            };

            if (ModelState.IsValid)
            {
                db.Entry(project).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Details", new { id = ID });
            }
            ViewBag.SubjectID = new SelectList(db.Subjects, "ID", "Name", project.SubjectID);
            return View(project);
        }

        // GET: Projects/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Project project = db.Projects.Find(id);
            if (project == null)
            {
                return HttpNotFound();
            }
            return View(project);
        }

        // POST: Projects/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Project project = db.Projects.Find(id);
            db.Projects.Remove(project);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
