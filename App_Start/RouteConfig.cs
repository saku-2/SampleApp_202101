using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SampleApp_202101
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",

                // TODOアプリ
                defaults: new { controller = "Menu", action = "Index", id = UrlParameter.Optional }

                // 音声合成サンプル(by さち♪)
                //defaults: new { controller = "Sample2", action = "Index", id = UrlParameter.Optional }

                // DropDownListFor ListBoxFor
                //defaults: new { controller = "Sample", action = "Sample", id = UrlParameter.Optional }

                // ViewHelperだよ♪
                //defaults: new { controller = "ViewHelper", action = "Mailto", id = UrlParameter.Optional }

                // バックアップ（ファイルコピー処理）
                //defaults: new { controller = "CsvBackUp", action = "CsvBackUpIndex", id = UrlParameter.Optional }

                //LINQの練習だよーーー
                //defaults: new { controller = "LINQ", action = "Index", id = UrlParameter.Optional }

                );
        }
    }
}
