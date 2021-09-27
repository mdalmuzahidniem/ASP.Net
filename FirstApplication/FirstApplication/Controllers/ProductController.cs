using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstApplication.Models;
using System.Data.SqlClient;

namespace FirstApplication.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Create(Product s)
        {
            string connString = @"Server=DESKTOP-T8L630M;Database=.net;Integrated Security=true";
            SqlConnection conn = new SqlConnection(connString);
            String query = String.Format("Insert into Products values ('{0}','{1}','{2}','{3}')",s.Name,s.Price,s.Quantity,s.Description);
            SqlCommand cmd = new SqlCommand(query,conn);
            conn.Open();
            int r =cmd.ExecuteNonQuery();
            conn.Close();
            return View();
        }
        public ActionResult CreateSubmit(Product s) {
            return View(s);
        }
        
    }
}