using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Globalization;
using System.Threading;

namespace KidsGEPT
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Application_BeginRequest(Object sender, EventArgs e)
        {
            HttpCookie Lang = Request.Cookies["GAI_Lang"];
            if (Lang != null)
            {
                Thread.CurrentThread.CurrentCulture = new CultureInfo(Lang.Value);
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(Lang.Value);
            }
        }
    }
}
