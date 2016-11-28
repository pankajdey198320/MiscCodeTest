using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UnityExplore.BL;

namespace UnityExplore.Controllers
{
    public class DefaultController : Controller
    {

        public IBL XBL { get {
                return fact.CreateBL("X");
            } }
        public IBLFactory fact { get; set; }
        public DefaultController(IBLFactory fac)
        {
            this.fact = fac;
            var x = this.XBL as XBL;
            x.XPrint();
        }
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
    }
}