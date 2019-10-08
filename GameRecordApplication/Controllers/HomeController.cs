using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameRecordApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        public ActionResult Maintenance()
        {
            ViewBag.Message = "Maintenance Page";
            return View();
        }

        public ActionResult GameStats()
        {
            ViewBag.Message = "Game and Stats Page";

            return View();
        }

        //[HttpPost]
        public ActionResult SideMenu()
        {
            return PartialView("SideMenuPartial");
        }
    }
}