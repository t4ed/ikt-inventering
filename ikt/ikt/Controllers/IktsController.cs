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
using ikt.ViewModels;

namespace ikt.Controllers
{
    public class IktsController : Controller
    {
        private iktContext db = new iktContext();

        // GET: Ikts
        public ActionResult Index()
        {
            var Ikts = db.Ikts.Include(P => P.ID);
            return View(db.Ikts.ToList());
        }

        // GET: Ikts/Details/5
        public ActionResult Details(int? id)
        {
            IktDetailsViewModel viewModel = new IktDetailsViewModel();
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ikt ikt = db.Ikts.Find(id);
            if (ikt == null)
            {
                return HttpNotFound();
            }
            viewModel.Ikt = ikt;
            viewModel.IktClass = db.IktClasses.Where(i => i.IktID == id).ToList();
            viewModel.IktStaff = db.IktStaffs.Where(i => i.IktID == id).ToList();
            return View(viewModel);
        }

        // GET: Ikts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ikts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(string Name, string ClassID, string Description, string Comment, string Link, string CreatedBy)
        {
            Ikt Ikts = new Ikt
            {
                Name = Name,
                Description = Description,
                Comment = Comment,
                Link = Link,
                CreatedBy = CreatedBy,
                CreatedDate = DateTime.Now
            };

            if (ModelState.IsValid)
            {
                Ikts.UpdatedDate = Ikts.CreatedDate;
                Ikts.UpdatedBy = Ikts.CreatedBy;
                db.Ikts.Add(Ikts);

                db.IktStaffs.Add(new IktStaff()
                {
                    IktID = Ikts.ID,
                    StaffID = db.Staff.Where(s => s.Username == Ikts.CreatedBy).Single().ID,
                    CreatedDate = DateTime.Now,
                    CreatedBy = Ikts.CreatedBy,
                    UpdatedDate = DateTime.Now,
                    UpdatedBy = Ikts.UpdatedBy
                });

                string[] classes;
                if (string.IsNullOrEmpty(ClassID))
                {
                    classes = new string[0];
                }
                else
                {
                    classes = ClassID.Split(',');
                }

                for (int i = 0; i < classes.Length; i++)
                {
                    db.IktClasses.Add(new IktClass()
                    {
                        IktID = Ikts.ID,
                        ClassID = Convert.ToInt32(classes[i]),
                        CreatedDate = DateTime.Now,
                        CreatedBy = Ikts.CreatedBy,
                        UpdatedDate = DateTime.Now,
                        UpdatedBy = Ikts.UpdatedBy
                    });
                }

                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View(Ikts);
        }

        // GET: Ikts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ikt ikt = db.Ikts.Find(id);
            if (ikt == null)
            {
                return HttpNotFound();
            }
            List<IktClass> ic = db.IktClasses.Where(c => c.IktID == id).ToList();

            string klassList = "";
            foreach (var klass in ic)
            {
                klassList += klass.ClassID + ",";
            }
            if (klassList.Length > 0)
            {
                klassList = klassList.Substring(0, klassList.Length - 1);
            }
            ViewBag.ClassList = klassList;
            return View(ikt);
        }

        // POST: Ikts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int ID, string Name, string Description, string ClassID, string OldClassList, string Comment, string Link, string CreatedBy, string CreatedDate, string UpdatedBy)
        {
            Ikt Ikts = new Ikt
            {
                ID = ID,
                Name = Name,
                Description = Description,
                Comment = Comment,
                Link = Link,
                CreatedBy = CreatedBy,
                CreatedDate = DateTime.Parse(CreatedDate),
                UpdatedBy = UpdatedBy,
                UpdatedDate = DateTime.Now
            };

            if (ModelState.IsValid)
            {
                string[] newClasses;
                string[] oldClasses;
                if (string.IsNullOrEmpty(ClassID))
                {
                    newClasses = new string[0];
                }
                else
                {
                    newClasses = ClassID.Split(',');
                }
                if (string.IsNullOrEmpty(OldClassList))
                {
                    oldClasses = new string[0];
                }
                else
                {
                    oldClasses = OldClassList.Split(',');
                }
                List<string> remove = Constants.GetClassesToRemove(oldClasses, newClasses);
                List<string> add = Constants.GetClassesToAdd(oldClasses, newClasses);

                foreach (var toAdd in add)
                {
                    db.IktClasses.Add(new IktClass
                    {
                        ClassID = Convert.ToInt32(toAdd),
                        IktID = Ikts.ID,
                        CreatedDate = DateTime.Now,
                        CreatedBy = CreatedBy,
                        UpdatedDate = DateTime.Now,
                        UpdatedBy = CreatedBy
                    });
                }

                foreach (var toRemove in remove)
                {
                    int removeID = Convert.ToInt32(toRemove);
                    db.IktClasses.Remove(db.IktClasses.Where(c => c.ClassID == removeID && c.IktID == Ikts.ID).Single());
                }

                db.Entry(Ikts).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Details", new { id = ID });
            }
            return View(Ikts);
        }

        // GET: Ikts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ikt ikt = db.Ikts.Find(id);
            if (ikt == null)
            {
                return HttpNotFound();
            }
            db.IktClasses.RemoveRange(db.IktClasses.Where(c => c.IktID == id));
            db.IktStaffs.RemoveRange(db.IktStaffs.Where(s => s.IktID == id));
            db.Ikts.Remove(ikt);
            db.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        // POST: Ikts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Ikt ikt = db.Ikts.Find(id);
            db.Ikts.Remove(ikt);
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

        public ActionResult AddStaff(int iktID, int staffID)
        {
            IktStaff iktStaff = new IktStaff
            {
                StaffID = staffID,
                IktID = iktID,
                CreatedBy = db.Staff.Single(s => s.ID == staffID).Username,
                CreatedDate = DateTime.Now,
                UpdatedBy = db.Staff.Single(s => s.ID == staffID).Username,
                UpdatedDate = DateTime.Now
            };

            db.IktStaffs.Add(iktStaff);
            db.SaveChanges();

            return RedirectToAction("Details", new { id = iktID });
        }

        public ActionResult RemoveStaff(int id, int iktID)
        {
            db.IktStaffs.Remove(db.IktStaffs.Where(i => i.ID == id).Single());
            db.SaveChanges();

            return RedirectToAction("Details", new { id = iktID });
        }
    }
}
