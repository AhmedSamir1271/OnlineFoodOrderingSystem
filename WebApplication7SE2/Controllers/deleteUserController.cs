using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication7SE2.Models;

namespace WebApplication7SE2.Controllers
{
    public class deleteUserController : Controller
    {
        private foodorderEntities2 db = new foodorderEntities2();

        public ActionResult deleteUser()
        {
            List<user> user = db.users.ToList();
            return View(user);
        }

        public ActionResult deleteUserConfirmed(int id)
        {
            var user = db.users.Find(id);
            db.users.Remove(user);
            db.SaveChanges();
            return RedirectToAction("deleteUser");
        }
    }
}