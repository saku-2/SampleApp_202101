using SampleApp_202101.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleApp_202101.Controllers
{
    public class SampleController : Controller
    {
        SampleApp_202101Context db = new SampleApp_202101Context();


        // Linq https://codezine.jp/article/detail/8378
        // SelectListItem https://www.buildinsider.net/web/bookaspmvc5/040204
        // 書き方　https://miso-soup3.hateblo.jp/entry/2013/12/05/041302
        // GET: Sample
        public ActionResult Sample(int? id = 1)
        {
            SampleModel model = new SampleModel();

            //IQueryable<SampleModel> list = db.SampleModel; //（2）全件取得
            //foreach (var sample in list)
            //{
            //    model.TodoCategoryId = sample.TodoCategoryId;
            //    model.TodoCategoryContents = sample.TodoCategoryContents;

            //    model.TodoCategoryContentsList = new List<SelectListItem>()
            //    {
            //        new SelectListItem()
            //         {
            //             Value = sample.TodoCategoryId.ToString(),
            //             Text = sample.TodoCategoryContents
            //        }
            //    };
            //};

            //ViewBag.TodoCategoryContentsList = db.SampleModel.Select(s => new SelectListItem
            model.TodoCategoryContentsList = db.SampleModel.Select(s => new SelectListItem
            {
                Value = s.TodoCategoryId.ToString(),
                Text = s.TodoCategoryContents,
            });
            return View(model);
        }

        [HttpPost]
        public ActionResult Radio(int? id, SampleModel model)
        {
            var a = model.RadioName;


            //return RedirectToAction("Sample");
            return RedirectToAction("Sample", "Sample");
        }

        [HttpPost]
        //public ActionResult List([Bind(Include = "SampleId, RadioName, TodoCategoryContents, TodoCategoryContentsList")]  SampleModel model)
        public ActionResult List(SampleModel model)
        {
            var a = model.TodoCategoryContents;



            //return RedirectToAction("Sample");
            return RedirectToAction("Sample", "Sample");
        }
    }
}