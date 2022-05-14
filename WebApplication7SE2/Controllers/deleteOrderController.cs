using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication7SE2.Models;

namespace WebApplication7SE2.Controllers
{
    public class deleteOrderController : Controller
    {
        private foodorderEntities1 db = new foodorderEntities1();

        public ActionResult deleteOrder()
        {
            List<order> order = db.orders.ToList();
            return View(order);
        }

        public ActionResult deleteOrderConfirmed(int id)
        {
            var order = db.orders.Find(id);
            db.orders.Remove(order);
            db.SaveChanges();
            return RedirectToAction("deleteOrder");
        }
    }
}