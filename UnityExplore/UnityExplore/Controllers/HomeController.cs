using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UnityExplore.BL;

namespace UnityExplore.Controllers
{
    public class HomeController : Controller
    {

        public HomeController(IBLFactory fac)
        {
            var d = fac.CreateBL("M");
            d.DoPrint();
        }
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
    }
}