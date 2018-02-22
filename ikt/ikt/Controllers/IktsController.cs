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
    public class IktsController : Controller
    {
        private iktContext db = new iktContext();

        // GET: Ikts
        public ActionResult Index()
        {
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
            viewModel.Ikt = ikt;
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
        public ActionResult Create([Bind(Include = "ID,Name,Description,Comment,Link")] Ikt ikt)
        {
            if (ModelState.IsValid)
            {
                db.Ikts.Add(ikt);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ikt);
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
            return View(ikt);
        }

        // POST: Ikts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Description,Comment,Link")] Ikt ikt)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ikt).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ikt);
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
            return View(ikt);
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
    }
}
