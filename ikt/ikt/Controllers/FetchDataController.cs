using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ikt.DAL;
using ikt.Models;

namespace ikt.Controllers
{
    public class FetchDataController : Controller
    {
        private iktContext db = new iktContext();
        // GET: Ajax
        public JsonResult FetchSubjectData()
        {
            var subjectList = db.Subjects.ToList();
            return Json(subjectList, JsonRequestBehavior.AllowGet);
        }

        public JsonResult FetchClassData()
        {
            var classList = db.Classes.ToList();
            return Json(classList, JsonRequestBehavior.AllowGet);
        }
    }
}