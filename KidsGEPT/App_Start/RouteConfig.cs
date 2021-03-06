﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace KidsGEPT
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Main", action = "Index", id = UrlParameter.Optional },
                namespaces: new string[] { "KidsGEPT.Controllers" }
            );

            routes.MapRoute(
                name: "Backend",
                url: "Backend/{controller}/{action}/{id}",
                defaults: new { controller = "Main", action = "Login", id = UrlParameter.Optional },
                namespaces: new string[] { "KidsGEPT.Areas.backend.Controllers" }
            );
        }
    }
}
