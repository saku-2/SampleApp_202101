using SampleApp_202101.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace SampleApp_202101.Controllers
{
    public class MenuController : Controller
    {
        SampleApp_202101Context db = new SampleApp_202101Context();

        // GET: Menu
        public ActionResult Index()
        {
            // asp.net mvc と　SqlServerの接続方法
            // https://qiita.com/zaburo/items/610bd34df3c819c67551
            //IQueryable<TodoModel> members = db.TodoModel.OrderBy(b => b.TodoId);
            //var todo = db.TodoModel.ToList();
            //var todo = db.Database.SqlQuery<TodoModel>("SELECT * FROM Todo;");
            var todo = db.TodoModel.Select(x => x);

            //javascript(jQery)
            //$("a[href='/Menu/Edit/8']").parents("tr").children('td')[3]


            return View(todo);
        }

        // GET: Menu/Create
        public ActionResult CreateTodo()
        {
            //Category category = new Category();
            TodoModel todo = new TodoModel();
            todo.TodoCategoryContents = db.Category.Select(s => new SelectListItem
            {
                Value = s.CategoryId.ToString(),
                Text = s.TodoCategoryContents,
                //Selected = x.Value == Model.PrefectureCode
            });

            return View(todo);
        }

        // POST: Members/Create
        // 過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
        // 詳細については、https://go.microsoft.com/fwlink/?LinkId=317598 をご覧ください。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateTodo(
            [Bind(Include = "TodoId,Priority,TodoCategoryContents,TodoItem")] TodoModel todo, int? val)
        {
            if (ModelState.IsValid)
            {
                db.TodoModel.Add(todo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(todo);
        }

        // GET: Members/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TodoModel todo = db.TodoModel.Find(id);
            if (todo == null)
            {
                return HttpNotFound();
            }
            return View(todo);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TodoId,Priority,TodoCategoryContents,TodoItem")] TodoModel todo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(todo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(todo);
        }

        // GET: Members/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TodoModel todo = db.TodoModel.Find(id);
            if (todo == null)
            {
                return HttpNotFound();
            }
            return View(todo);
        }

        // POST: Members/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TodoModel todo = db.TodoModel.Find(id);
            db.TodoModel.Remove(todo);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}