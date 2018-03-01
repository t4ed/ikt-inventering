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
    public class StaffsController : Controller
    {
        private iktContext db = new iktContext();

        // GET: Staffs/Create
        public ActionResult Create(string Username)
        {
            ViewBag.Username = Username;
            return View();
        }

        // POST: Staffs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create([Bind(Include = "ID,Username,FirstName,LastName,CreatedDate")] Staff staff)
        {
            if (ModelState.IsValid)
            {
                staff.UpdatedDate = staff.CreatedDate;
                staff.UpdatedBy = staff.CreatedBy;
                db.Staff.Add(staff);
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            ViewBag.Username = staff.Username;
            return View(staff);
        }
    }
}
