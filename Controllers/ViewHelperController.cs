using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleApp_202101.Controllers
{
    public class ViewHelperController : Controller
    {
        // GET: ViewHelper
        public ActionResult Mailto()
        {
            return View();
        }
    }
}