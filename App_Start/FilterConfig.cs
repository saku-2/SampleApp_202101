﻿using System.Web;
using System.Web.Mvc;

namespace SampleApp_202101
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}