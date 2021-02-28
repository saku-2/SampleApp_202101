using SampleApp_202101.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleApp_202101.Controllers
{
    public class CategoryController : Controller
    {
        SampleApp_202101Context db = new SampleApp_202101Context();

        // GET: Category
        public ActionResult Index(int? id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult MakeCategory([Bind(Include = "CategoryId,TodoCategoryContents,UserId")] Category category, int? id)
        {
            category.UserId = 1;

            if (!ModelState.IsValid)
            {
                db.Category.Add(category);
                db.SaveChanges();
                return RedirectToAction("Index", "Menu");
            }
            return RedirectToAction("Index");
        }
    }
}