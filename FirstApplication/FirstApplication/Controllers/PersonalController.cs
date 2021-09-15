using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstApplication.Controllers
{
    public class PersonalController : Controller
    {
        
        public ActionResult List()
        {
            return View();
        }
    }
}