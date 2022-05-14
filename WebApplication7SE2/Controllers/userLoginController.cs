using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication7SE2.Models;

namespace WebApplication7SE2.Controllers
{
    public class userLoginController : Controller
    {
        private foodorderEntities2 db = new foodorderEntities2();

        // GET: adminLogin
        public ActionResult userLogin()
        {
            return View();
        }

        public ActionResult Autherize(WebApplication7SE2.Models.user userModel)
        {
            using (db)
            {
                var userDetails = db.users.Where(x => x.user_name == userModel.user_name && x.password == userModel.password).FirstOrDefault();
                if (userDetails == null)
                {
                    userModel.LoginErrorMessage = "Wrong username or password.";
                    return View("userLogin", userModel);
                }
                else
                {
                    Session["userId"] = userDetails.Id;
                    Session["userName"] = userDetails.user_name;
                    return RedirectToAction("userHome", "userHome");
                }
            }
        }

        public ActionResult LogOut()
        {
            int adminId = (int)Session["userId"];
            Session.Abandon();
            return RedirectToAction("userLogin", "userLogin");
        }
    }
}