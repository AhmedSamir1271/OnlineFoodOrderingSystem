using System;
using System.Collections;
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
    public class deleteAdminController : Controller
    {
        private foodorderEntities1 db = new foodorderEntities1();

        public ActionResult deleteAdmin()
        {
            List <admin> admin = db.admins.ToList();
            return View(admin);
        }
        
        public ActionResult deleteAdminConfirmed(int id)
        {
            var admin = db.admins.Find(id);
            db.admins.Remove(admin);
            db.SaveChanges();
            return RedirectToAction("deleteAdmin");
        }
        
    }
}
