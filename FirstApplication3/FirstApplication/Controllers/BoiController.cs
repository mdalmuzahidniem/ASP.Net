using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstApplication.Models;

namespace FirstApplication.Controllers
{
    public class BoiController : Controller
    {
        public ActionResult Index() {
            //ViewBag.Name = "nayim";

            /*string[] names = new string[3];
            names[0] = "Al";
            names[1] = "Muzahid";
            names[2] = "Nayim";
            ViewBag.Names = names;*/
            Student s1 = new Student() {
                Name = "nayim",
                Id="18-38045-2"
            };
            
            return View(s1);
        }
        public ActionResult List() {
            List<Student> students = new List<Student>();
            for (int i = 0; i < 10; i++) {
                Student s2 = new Student()
                {
                    Name = "nayim" + (i + 1),
                    Id="123"+(i+1)
                };
                students.Add(s2);
            }
            return View(students);

        }
        public ActionResult Create() {
            return View();
        }
        public ActionResult CreateSubmit(Student s)
        {  
            return View(s);
        }
    }
}