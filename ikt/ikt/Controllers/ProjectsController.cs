﻿using System;
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
            ProjectDetailsViewModel viewModel = new ProjectDetailsViewModel();
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Project project = db.Projects.Find(id);
            if (project == null)
            {
                return HttpNotFound();
            }
            viewModel.Project = project;
            viewModel.ProjectClass = db.ProjectClasses.Where(p => p.ProjectID == id).ToList();
            viewModel.ProjectStaff = db.ProjectStaffs.Where(p => p.ProjectID == id).ToList();
            return View(viewModel);
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
        public ActionResult Create(string Name, string SubjectID, string ClassID, int Grade, string Description, string Date, string CreatedBy, HttpPostedFileBase file)
        {
            Project project = new Project();
            int subjectID = 0;
            try
            {
                subjectID = db.Subjects.Where(s => s.Name == SubjectID).Single().ID;
            }
            catch
            {
                ModelState.AddModelError("SubjectID", "Ämnet finns inte.");
            }
            if (ModelState.IsValid)
            {
                project = new Project
                {
                    Name = Name,
                    SubjectID = subjectID,
                    Grade = Grade,
                    Description = Description,
                    Date = Date,
                    CreatedDate = DateTime.Now,
                    CreatedBy = CreatedBy,
                    UpdatedDate = DateTime.Now,
                    UpdatedBy = CreatedBy
                };
            }
            if (file != null)
            {
                if (ValidateFile(file))
                {
                    try
                    {
                        if (ModelState.IsValid)
                        {
                            Random r = new Random();
                            string newName;
                            do
                            {
                                newName = Convert.ToString(r.Next());
                            } while (System.IO.File.Exists(Constants.FilePath + newName));
                            newName += ".pdf";
                            SaveToDisk(file, newName);
                            project.PDF = newName;
                        }
                    }
                    catch (Exception e)
                    {
                        ModelState.AddModelError("PDF", "Ett okänt fel inträffade. Vänligen försök igen. " + e.Message);
                    }
                }
                else
                {
                    ModelState.AddModelError("PDF", "Filen " + file.FileName + " orsakade ett fel. Kolla att det är en PDF-fil och att den är mindre än " + Constants.MaxFileSizeMB + "MB");
                }
            }


            if (ModelState.IsValid)
            {
                db.Projects.Add(project);

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
                    db.ProjectClasses.Add(new ProjectClass
                    {
                        ClassID = Convert.ToInt32(classes[i]),
                        ProjectID = project.ID,
                        CreatedDate = DateTime.Now,
                        CreatedBy = CreatedBy,
                        UpdatedDate = DateTime.Now,
                        UpdatedBy = CreatedBy
                    });
                }

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
                return RedirectToAction("Index", "Home");
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

            List<ProjectClass> pc = db.ProjectClasses.Where(c => c.ProjectID == id).ToList();

            string klassList = "";
            foreach (var klass in pc)
            {
                klassList += klass.ClassID + ",";
            }
            if (klassList.Length > 0)
            {
                klassList = klassList.Substring(0, klassList.Length - 1);
            }
            ViewBag.ClassList = klassList;

            return View(project);
        }

        // POST: Projects/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int ID, string Name, int Grade, string SubjectID, string ClassID, string OldClassList, string PDF, string Description, string Date, string CreatedBy, string CreatedDate, string UpdatedBy, HttpPostedFileBase file)
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

            if (file != null)
            {
                if (ValidateFile(file))
                {
                    try
                    {
                        if (ModelState.IsValid)
                        {
                            string newName;
                            if (string.IsNullOrEmpty(PDF))
                            {
                                Random r = new Random();
                                do
                                {
                                    newName = Convert.ToString(r.Next());
                                } while (System.IO.File.Exists(Constants.FilePath + newName));
                                newName += ".pdf";
                            }
                            else
                            {
                                newName = PDF;
                            }
                            SaveToDisk(file, newName);
                            project.PDF = newName;
                        }
                    }
                    catch (Exception e)
                    {
                        ModelState.AddModelError("PDF", "Ett okänt fel inträffade. Vänligen försök igen. " + e.Message);
                    }
                }
                else
                {
                    ModelState.AddModelError("PDF", "Filen " + file.FileName + " orsakade ett fel. Kolla att det är en PDF-fil och att den är mindre än " + Constants.MaxFileSizeMB + "MB");
                }
            }
            else if (!string.IsNullOrEmpty(PDF))
            {
                project.PDF = PDF;
            }


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
                if (add.Count > 0)
                {
                    foreach (var toAdd in add)
                    {
                        db.ProjectClasses.Add(new ProjectClass
                        {
                            ClassID = Convert.ToInt32(toAdd),
                            ProjectID = project.ID,
                            CreatedDate = DateTime.Now,
                            CreatedBy = CreatedBy,
                            UpdatedDate = DateTime.Now,
                            UpdatedBy = CreatedBy
                        });
                    }
                }
                if (remove.Count > 0)
                {
                    foreach (var toRemove in remove)
                    {
                        int removeID = Convert.ToInt32(toRemove);
                        db.ProjectClasses.Remove(db.ProjectClasses.Where(c => c.ClassID == removeID && c.ProjectID == project.ID).Single());
                    }
                }

                db.Entry(project).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Details", new { id = ID });
            }
            ViewBag.SubjectID = new SelectList(db.Subjects, "ID", "Name", project.SubjectID);
            ViewBag.OldClassList = OldClassList;
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
            db.ProjectStaffs.RemoveRange(db.ProjectStaffs.Where(s => s.ProjectID == id));
            db.ProjectClasses.RemoveRange(db.ProjectClasses.Where(c => c.ProjectID == id));
            db.Projects.Remove(project);
            db.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        // POST: Projects/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Project project = db.Projects.Find(id);
            db.ProjectStaffs.RemoveRange(db.ProjectStaffs.Where(s => s.ProjectID == id));
            db.ProjectClasses.RemoveRange(db.ProjectClasses.Where(c => c.ProjectID == id));
            db.Projects.Remove(project);
            db.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        public ActionResult AddStaff(int projectID, int staffID)
        {
            ProjectStaff projectStaff = new ProjectStaff
            {
                StaffID = staffID,
                ProjectID = projectID,
                CreatedBy = db.Staff.Single(s => s.ID == staffID).Username,
                CreatedDate = DateTime.Now,
                UpdatedBy = db.Staff.Single(s => s.ID == staffID).Username,
                UpdatedDate = DateTime.Now
            };

            db.ProjectStaffs.Add(projectStaff);
            db.SaveChanges();

            return RedirectToAction("Details", new { id = projectID });
        }

        public ActionResult RemoveStaff(int id, int projectID)
        {
            db.ProjectStaffs.Remove(db.ProjectStaffs.Where(i => i.ID == id).Single());
            db.SaveChanges();

            return RedirectToAction("Details", new { id = projectID });
        }

        private bool ValidateFile(HttpPostedFileBase file)
        {
            string[] allowedFileTypes = { ".pdf" };
            string fileExtension = System.IO.Path.GetExtension(file.FileName).ToLower();

            if (allowedFileTypes.Contains(fileExtension))
            {
                if (file.ContentLength > 0 && file.ContentLength < Constants.MegabytesToBytes(Constants.MaxFileSizeMB))
                {
                    return true;
                }
            }
            return false;
        }

        private void SaveToDisk(HttpPostedFileBase file, string newName)
        {
            file.SaveAs(Server.MapPath(Constants.FilePath + newName));
        }
    }
}
