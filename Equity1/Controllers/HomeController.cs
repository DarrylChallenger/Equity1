using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Equity1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Test for me";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "What is EQUITY, etc...";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Initiatives()
        {
            ViewBag.Message = "How will EQUITY be launched, etc...";
            return View();
        }

        public ActionResult OurTeam()
        {
            ViewBag.Message = "Organizing Team, Advisory Board with descriptions";
            return View();
        }

        public ActionResult Support()
        {
            ViewBag.Message = "Support";
            return View();
        }

        public ActionResult Gallery()
        {
            ViewBag.Message = "Gallery";
            return View();
        }

        public ActionResult Test()
        {
            ViewBag.Message = "Test";
            return View();
        }
    }
}