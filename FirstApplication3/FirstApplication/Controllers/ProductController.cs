using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstApplication.Models.Entity;
using FirstApplication.Models;
using System.Data.SqlClient;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using System.Web.Security;

namespace FirstApplication.Controllers
{
    public class ProductController : Controller
    {
        [HttpGet]
        [Authorize]
        public ActionResult Create()
        {
            return View();
        }
        // GET: Product
        [HttpPost]
        public ActionResult Create(Product s)
        {
            Database db = new Database();
            db.Products.Add(s);
            return View();
        }
        
        public ActionResult View() {
            Database db = new Database();
            var products = db.Products.GetAll();
            return View(products);
        }
        
        public ActionResult Cart(int id)
        {
            //Database db = new Database();
            //var p = db.Products.GetItem(id);
            Database db = new Database();
            var product = db.Products.GetItem(id);

            if (product != null)
            {
                List<Product> products = new List<Product>();

                if (Session["cart"] != null)
                {
                    var jsonString = Session["cart"].ToString();
                    var data = new JavaScriptSerializer().Deserialize<List<Product>>(jsonString);
                    data.Add(product);
                    Session["cart"] = new JavaScriptSerializer().Serialize(data);
                    return Redirect("/product/Checkout");
                }
                else
                {

                    products.Add(product);
                    string jsonString = new JavaScriptSerializer().Serialize(products);
                    Session["cart"] = jsonString;
                    Session["Message"] = null;
                    return Redirect("/product/Checkout");


                }

            }
            return Redirect("/product/Checkout");

            //return View(p);
        }
        public ActionResult Checkout()
        {
            if (Session["cart"] != null)
            {
                var products = new JavaScriptSerializer().Deserialize<List<Product>>(Session["cart"].ToString());


                return View(products);

            }
            Session["Message"] = "True";
            return Redirect("/product/View");
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string Username, string Password)
        {
            Database db = new Database();
            var user = db.Users.Authenticate(Username, Password);
            if (user != null)
            {
                FormsAuthentication.SetAuthCookie(user.Username, true);
                return RedirectToAction("Create");
            }
            ViewBag.massage = "Invalid username or password";
            return View();
        }
    }
}