using phase1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace phase1.Controllers
{
    public class CartsController : Controller

    {
        private storeEntities2 db = new storeEntities2();
        // GET: Carts
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddToCart(int id)
        {
            var Cart = new Cart();
            DateTime localDate = DateTime.Now;
            Cart.added_at = localDate;
            Cart.product_id = id;
            var cart2 = db.Carts.Find(id);
            if (cart2 != null)
            {
                return RedirectToAction("Filter", "products");
            }
            else
            {
                db.Carts.Add(Cart);
                db.SaveChanges();
                return RedirectToAction("Filter", "products");
            }
        }
        public ActionResult Remove(int id)
        {
            var _cart = db.Carts.Find(id);
            if (_cart != null)
            {
                db.Carts.Remove(_cart);
            }
            db.SaveChanges();
            return RedirectToAction("Filter", "products");
        }

    }
}