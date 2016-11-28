using System.Threading.Tasks;
using System.Web.Mvc;

namespace SfcApi.Controllers
{
    public class TemplateController : Controller
    {
        public async  Task<ActionResult> TestCompTemp()
        {
            return  View();
        }

        public async Task<ActionResult> DesignComp()
        {
            return  View();
        }
    }
}
