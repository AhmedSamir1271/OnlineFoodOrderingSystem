using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication7SE2.Models;

namespace WebApplication7SE2.Controllers
{
    public class adminLoginController : Controller
    {
        private foodorderEntities1 db = new foodorderEntities1();

        // GET: adminLogin
        public ActionResult adminLogin()
        {
            return View();
        }

        public ActionResult Autherize(WebApplication7SE2.Models.admin adminModel)
        {
            using (db)
            {
                var adminDetails = db.admins.Where(x => x.user_name == adminModel.user_name && x.password == adminModel.password).FirstOrDefault();
                if (adminDetails == null)
                {
                    adminModel.LoginErrorMessage = "Wrong username or password.";
                    return View("adminLogin", adminModel);
                }
                else
                {
                    Session["adminId"] = adminDetails.id;
                    Session["adminName"] = adminDetails.user_name;
                    return RedirectToAction("adminHome", "adminHome");
                }
            }
        }

        public ActionResult LogOut()
        {
            int adminId = (int)Session["adminId"];
            Session.Abandon();
            return RedirectToAction("adminLogin", "adminLogin");
        }
    }
}