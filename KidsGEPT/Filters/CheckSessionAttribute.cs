using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidsGEPT.Models;

namespace KidsGEPT.Filters
{
    public class CheckSessionAttribute : AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            base.OnAuthorization(filterContext);

            HttpContext httpcontext = HttpContext.Current;

            if (httpcontext.Session != null)
            {
                if (httpcontext.Session.IsNewSession)
                {
                    String sessioncookie = httpcontext.Request.Headers["Cookie"];
                    if ((sessioncookie != null) && (sessioncookie.IndexOf("ASP.NET_SessionId") >= 0))
                    {
                        filterContext.Result = new RedirectResult("/Main/Login");
                    }
                }
            }
        }       
    }
}