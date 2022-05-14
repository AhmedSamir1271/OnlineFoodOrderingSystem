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
    public class addUserController : Controller
    {
        private foodorderEntities2 db = new foodorderEntities2();

        public ActionResult addUser()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult addUser([Bind(Include = "id,full_name,user_name,password")] user user)
        {
            throw new NotImplementedException();
        }
    }
}