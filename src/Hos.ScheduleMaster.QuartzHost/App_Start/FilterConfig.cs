﻿using System.Web;
using System.Web.Mvc;

namespace Hos.ScheduleMaster.QuartzHost
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
