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

        [HttpPost]
        public JsonResult foodCart(string ItemId)
        {
            order objorder = new order();
            food food = db.foods.Single(model => model.id.ToString() == ItemId);
            if (Session["CartCount"] != null)
            {
                listOfOrders = Session["CartItem"] as List<order>;
            }
            if (listOfOrders.Any(model => model.id.ToString() == ItemId))
            {
                objorder = listOfOrders.Single(model => model.id.ToString() == ItemId);
                objorder.qty = objorder.qty + 1;
                objorder.total = objorder.qty * objorder.price;
            }
            else
            {
                var objorderId = objorder.id.ToString();
                objorderId = ItemId;
                objorder.image_name = food.image_name;
                objorder.food = food.title;
                objorder.qty = 1;
                objorder.total = food.price;
                objorder.price = food.price;
                listOfOrders.Add(objorder);
            }
            Session["CartCounter"] = listOfOrders.Count;
            Session["CartItem"] = listOfOrders;
            return Json(new { success = true, Counter = listOfOrders.Count }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult OrderCart()
        {
            listOfOrders = Session["CartItem"] as List<order>;
            return View(listOfOrders);
        }
    }
}