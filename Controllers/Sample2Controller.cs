using SampleApp_202101.Models;
using System.Web.Mvc;

namespace SampleApp_202101.Controllers
{
    public class Sample2Controller : Controller
    {
        // GET: Sample2
        public ActionResult Index()
        {
            return View(new Sample2Model());
        }
    }
}