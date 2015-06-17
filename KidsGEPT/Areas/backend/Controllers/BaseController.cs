using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidsGEPT.Models;
using KidsGEPT.Models.Repository;
using KidsGEPT.Areas.backend.Models;
using System.Data.Entity;

namespace KidsGEPT.Areas.backend.Controllers
{
    public class BaseController : Controller
    {
        protected KidsGEPTEntities db = new KidsGEPTEntities();
        protected int pageSize = 10;
        // 建構quotationContext
        //protected UnitOfWork _unitofWork = new UnitOfWork();
        protected const string pwSalt = "weypro168";

        // GET: /Base/
        protected override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            //ViewBag.SiteLinks = _unitofWork.LimRepository.Get();

            base.OnActionExecuted(filterContext);
        }
        /// <summary>
        /// 下拉選單設定
        /// </summary>
        /// <param name="source">資料來源</param>
        /// <param name="selectedItem">預設選項</param>
        /// <returns></returns>
        protected List<SelectListItem> GetSelectList(List<SelectListModelcs> source, string selectedItem = null)
        {
            var selectList = source.Select(item => new SelectListItem()
            {
                Text = item.Name,
                Value = item.Val,
                Selected = !string.IsNullOrWhiteSpace(selectedItem) && item.Val.Equals(selectedItem, StringComparison.OrdinalIgnoreCase)
            });
            return selectList.ToList();
        }

    }
}