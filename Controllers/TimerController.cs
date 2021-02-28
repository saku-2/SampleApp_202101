using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Timers;
using System.Web;
using System.Web.Mvc;

namespace SampleApp_202101.Controllers
{
    public class TimerController : Controller
    {
        TimeSpan timer = new TimeSpan();
        TimeSpan totalTimer = new TimeSpan();
        DateTime start = new DateTime();
        DateTime stop = new DateTime();

        // GET: Index
        public ActionResult Index()
        {
            return View();
        }

        // GET: StartTimer
        [HttpPost]
        public ActionResult StartTimer()
        {
            start = DateTime.Now;

            return RedirectToAction("Index");
        }

        // GET: StartTimer
        [HttpPost]
        public ActionResult StopTimer()
        {
            stop = DateTime.Now;

            timer = stop - start;

            // timerをDBに記録する→リセットする

            // timer が大きすぎるときもリセットする。
            //if (timer > new TimeSpan())
            //{
            //    timer = new TimeSpan();
            //}

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult ResetTimer()
        {
             timer = new TimeSpan();
             start = new DateTime();
             stop = new DateTime();

            return RedirectToAction("Index");
        }

        public ActionResult RecordTimer()
        {
            //totalTimer = new TimeSpan();
            return RedirectToAction("Index");

        }

    }
}