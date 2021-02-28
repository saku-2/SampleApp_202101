using SampleApp_202101.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleApp_202101.Controllers
{
    public class LINQController : Controller
    {
        private readonly List<口座> 口座リスト = new List<口座>
        {
            new 口座
            {
                口座番号 = "0642191",
                名義 = "アオキ　ハルカ",
                種別 = 1,
                残高 = 3640551,
                更新日 = DateTime.Parse("2018-3-13"),
            },
            new 口座
            {
                口座番号 = "1039410",
                名義 = "キノシタ　リュウジ",
                種別 = 1,
                残高 = 259017,
                更新日 = DateTime.Parse("2017-11-30"),
            },
            new 口座
            {
                口座番号 = "1239855",
                名義 = "タカシナ　ミツル",
                種別 = 2,
                残高 = 6509773,
                更新日 = null,
            },
            new 口座
            {
                口座番号 = "1239856",
                名義 = "タカシナ　ミツル2",
                種別 = 2,
                残高 = 6509774,
                更新日 = null,
            },
        };




        // GET: LINQ
        public ActionResult Index()
        {
            #region ヒント
            //ver list = 口座リスト.Select(x => x);
            //ver list = 口座リスト.Select(x => new 番号残高 { 口座番号 = x口座番号, 残高 = x残高 });
            //var list = 口座リスト.Where(x => x.口座番号 == "1039410").Select(x => x);
            //var list = 口座リスト.Where(x => (new List<short> {2, 3}).Contains(x.種別)) .Select(x => x);
            //var list = 口座リスト.Where(x => [or条件」) .Select(x => x);
            //var list = 口座リスト.Where(x => )Where(x => ).Where(x => AND条件) .Select(x => x);
            //正規表現
            //var articles = db.Articles
            //.OrderByDescending(a => a.Published)
            //.ThenBy(a => a.Title);
            #endregion ヒント

            //var list = 口座リスト.Select(x => x);
            //var list = 口座リスト.Select(x => x.口座番号).ToList();
            //var list = 口座リスト.Select(x => {
            //    var l = new Dictionary<string, string>();
            //    l["口座番号"] = x.口座番号;
            //    l["残高"] = x.残高.ToString();
            //    return l;
            //}).ToList();
            //var list = 口座リスト.Where(x => x.口座番号 == "1039410").Select(x => x);
            //var list = 口座リスト.Where(x => x.残高 > 0).Select(x => x);
            //var list = 口座リスト.Where(x => int.Parse(x.口座番号) < 1000000).Select(x => x);
            //var list = 口座リスト.Where(x => x.更新日 != null && ((DateTime)x.更新日).Year <= 2017).Select(x => x);
            //var list = 口座リスト.Where(x => x.残高 >= 1000000);
            //var list = 口座リスト.Where(x => x.種別 != 1);
            //var list = 口座リスト.Where(x => x.更新日 == null);
            //var list = 口座リスト.OrderByDescending(x => x.口座番号);
            //var list = 口座リスト.Select(x => x.種別).Distinct().OrderBy(x => x);
            //var list = 口座リスト.Select(x => x).OrderBy(x => x.口座番号).ThenBy(x => x.残高);
            var list = 口座リスト.Where(x => x.更新日 !=null).Skip(0).Take(10);


            foreach (var en in list)
            {
                //Debug.WriteLine(
                Trace.WriteLine(
                    //Console.WriteLine
                    //"口座番号 = " + li.口座番号,
                    //"" + li.名義,
                    //"" + li.更新日,


                    string.Format("口座番号={0}", en)
                    //string.Format("口座番号={0} ", en.口座番号)
                    //+ string.Format("名義={0} ", en.名義)
                    //+ string.Format("更新日={0} ", en.更新日)
                    //+ string.Format("残高={0} ", en.残高)
                    //+ string.Format("種別={0} ", en.種別)

                    );
            }



            //return View();
            return new EmptyResult();
        }
    }
}