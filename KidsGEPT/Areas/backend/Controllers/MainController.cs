using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidsGEPT.Filters;
using KidsGEPT.Models;
using System.Web.Security;

namespace KidsGEPT.Areas.backend.Controllers
{
    public class MainController : BaseController
    {
        [AuthorizeBackend]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        // 執行登入
        [HttpPost]
        public ActionResult Login(string PID, string password)
        {
            // 清空所有session
            Session.Clear();

            if (ValidateUser(PID, password))
            {
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", ViewRes.Login.Loginerrormessage);
            return View();
        }

        // 執行登出
        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Login");
        }

        // 驗證帳號密碼
        private bool ValidateUser(string PID, string password)
        {
            if (PID == "A123456789" && password == "QQQQQ")
            {
                Session["backendauth"] = true;
                Session["backenduser"] = "Administrator";
                Session["backenduserid"] = "00000000-0000-0000-0000-000000000000";
                Session["backendbranchid"] = "00000000-0000-0000-0000-000000000000";
                Session["backendisheadquarter"] = 1;

                return true;
            }
            else
            {
                return false;
            }
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}