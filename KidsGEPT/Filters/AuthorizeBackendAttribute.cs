using System;
using System.Web.Mvc;

namespace KidsGEPT.Filters
{
    public class AuthorizeBackendAttribute : AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            if (!Convert.ToBoolean(filterContext.HttpContext.Session["backendauth"]))
            {
                filterContext.Result = new RedirectResult("~/backend/Main/Login");
            }
        }
    }
}