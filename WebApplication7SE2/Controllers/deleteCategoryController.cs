using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication7SE2.Models;

namespace WebApplication7SE2.Controllers
{
    public class deleteCategoryController : Controller
    {
        private foodorderEntities1 db = new foodorderEntities1();

        public ActionResult deleteCategory()
        {
            List<category> category = db.categories.ToList();
            return View(category);
        }

        public ActionResult deleteCategoryConfirmed(int id)
        {
            var category = db.categories.Find(id);
            db.categories.Remove(category);
            db.SaveChanges();
            return RedirectToAction("deleteCategory");
        }
    }
}
