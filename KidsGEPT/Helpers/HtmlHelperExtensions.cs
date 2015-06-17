using System;
using System.Reflection;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Collections.Generic;
using Microsoft.Ajax.Utilities;
using KidsGEPT.Models;

namespace KidsGEPT.Helpers
{
    public static class HtmlHelperExtensions
    {
        public static MvcHtmlString RouteIf(this HtmlHelper helper, string value, string attribute)
        {
            var currentController =
                (helper.ViewContext.RequestContext.RouteData.Values["controller"] ?? string.Empty).ToString().UnDash();
            var currentAction =
                (helper.ViewContext.RequestContext.RouteData.Values["action"] ?? string.Empty).ToString().UnDash();

            //value = value.Replace("Create", "").Replace("Update", "");

            var hasController = value.Equals(currentController, StringComparison.InvariantCultureIgnoreCase);
            var hasAction = value.Equals(currentAction, StringComparison.InvariantCultureIgnoreCase);

            return hasAction || hasController ? MvcHtmlString.Create(attribute) : MvcHtmlString.Create(string.Empty);
        }
    }
}