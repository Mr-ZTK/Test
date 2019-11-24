using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test_Partial.Models;

namespace Test_Partial.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<MenuItem> list = new List<MenuItem>();

            list.Add(new MenuItem { Link = "/Home/Index", LinkName = "Home" });
            list.Add(new MenuItem { Link = "/Home/About", LinkName = "Login" });
            list.Add(new MenuItem { Link = "/Home/Contact", LinkName = "Register" });

            return View(list);
        }

        public ActionResult SideMenu()
        {
            List<MenuItem> list = new List<MenuItem>();

            list.Add(new MenuItem { Link = "/Home/Index", LinkName = "Home" });
            list.Add(new MenuItem { Link = "/Home/About", LinkName = "Login" });
            list.Add(new MenuItem { Link = "/Home/Contact", LinkName = "Register" });


            return PartialView("SideMenu", list);
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}