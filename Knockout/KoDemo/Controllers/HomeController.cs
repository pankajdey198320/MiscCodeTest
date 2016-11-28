using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;


namespace KoDemo.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> KOComp()
        {
            return View();
        }
    }
}