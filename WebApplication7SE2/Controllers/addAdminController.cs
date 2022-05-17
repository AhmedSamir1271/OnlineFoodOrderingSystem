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
    public class addAdminController : Controller
    {
        private foodorderEntities1 db = new foodorderEntities1();

        public ActionResult addAdmin()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult addAdmin([Bind(Include = "id,full_name,user_name,password")] admin admin)
        {
            if (ModelState.IsValid)
            {
                db.admins.Add(admin);
                db.SaveChanges();
            }
            return View(admin);
        }
    }
}
