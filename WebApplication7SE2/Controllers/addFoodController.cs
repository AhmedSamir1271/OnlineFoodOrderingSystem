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
    public class addFoodController : Controller
    {
        private foodorderEntities1 db = new foodorderEntities1();

        public ActionResult addFood()
        {
            ViewBag.category_id = new SelectList(db.categories, "id", "title");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult addFood([Bind(Include = "id,title,description,price,image_name,category_id,featured,active")] food food)
        {
            throw new NotImplementedException();
        }
    }
}
