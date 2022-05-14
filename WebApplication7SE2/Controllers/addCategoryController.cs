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
    public class addCategoryController : Controller
    {
        private foodorderEntities1 db = new foodorderEntities1();

        public ActionResult addCategory()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult addCategory([Bind(Include = "id,title,image_name,featured,active")] category category)
        {
            throw new NotImplementedException();
        }
    }
}
