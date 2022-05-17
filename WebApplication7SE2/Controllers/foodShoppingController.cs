using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication7SE2.Models;

namespace WebApplication7SE2.Controllers
{
    public class foodShoppingController : Controller
    {
        private foodorderEntities1 db = new foodorderEntities1();
        List<order> listOfOrders = new List<order>();

        public ActionResult foodShopping()
        {
            List<food> list = db.foods.ToList();
            List<food> listOfFoods = new List<food>();
            foreach (var food in list)
            {
                listOfFoods.Add(food);
            }

            return View(listOfFoods);
        }
        
    }
}