using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication7SE2.Models;

namespace WebApplication7SE2.Controllers
{
    public class addOrderController : Controller
    {
        private foodorderEntities1 db = new foodorderEntities1();

        public ActionResult addOrder()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult addOrder([Bind(Include = "id,food,qty,order_date")] order order)
        {
            if (ModelState.IsValid)
            {
                db.orders.Add(order);
                db.SaveChanges();
            }

            return View(order);
        }
    }
}