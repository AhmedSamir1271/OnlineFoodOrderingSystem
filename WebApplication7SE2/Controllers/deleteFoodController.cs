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
    public class deleteFoodController : Controller
    {
        private foodorderEntities1 db = new foodorderEntities1();

        public ActionResult deleteFood()
        {
            List<food> food = db.foods.ToList();
            return View(food);
        }

        public ActionResult deleteFoodConfirmed(int id)
        {
            var food = db.foods.Find(id);
            db.foods.Remove(food);
            db.SaveChanges();
            return RedirectToAction("deleteFood");
        }
    }
}
