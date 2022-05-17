using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication7SE2.Models;

namespace WebApplication7SE2.Controllers
{
    public class orderListController : Controller
    {
        private foodorderEntities1 db = new foodorderEntities1();

        public ActionResult orderList()
        {
            List<order> order = db.orders.ToList();
            return View(order);
        }
    }
}