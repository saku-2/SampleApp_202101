using SampleApp_202101.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleApp_202101.Controllers
{
    public class SalesController : Controller
    {
        // GET: Sales
        public ActionResult Sales()
        {
            return View();
        }

        
        [HttpPost]
        public ActionResult DayControl()
        {
            SalesService service = new SalesService();
            //service.Result();

            return RedirectToAction("Sales", "Sales");
            //return RedirectToAction("CsvBackUpIndex", "CsvBackUp");
        }
    }
}