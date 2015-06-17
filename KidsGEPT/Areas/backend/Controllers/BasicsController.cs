using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using KidsGEPT.Models;
using PagedList;
using KidsGEPT.Models.Repository;
using KidsGEPT.Areas.backend.Models;

namespace KidsGEPT.Areas.backend.Controllers
{
    public class BasicsController : BaseController
    {
        // GET: backend/Basics
        public ActionResult Index(int? page, string typeselect)
        {
            //選單
           // ViewBag.typeselect = this.GetSelectList(Scheduledb.ToSelectitem(filter: x => x.BasicType == "Basic").Select(x => new SelectListModelcs { Name = x.Name, Val = x.Val }).ToList(), ""); 
            ViewBag.typeselect = this.GetSelectList();
            ViewBag.typeselected = typeselect;

            //過濾
            var source = (IEnumerable<KidsGEPT.Models.Basic>)db.Basic.Where(x => x.BasicType != "Basic");
            if (!string.IsNullOrWhiteSpace(typeselect))
            {
                source = source.Where(x => x.BasicType == typeselect);
            }

            //int currentPage = page < 1 ? 1 : page;
            //var resultlist = db.Basic.OrderBy(b => b.Type).ThenBy(b => b.BasicID).ThenBy(b => b.val).ToPagedList(currentPage, pageSize);
            //var resulselect = db.Basic.Where(b => (b.Type == "Basic")).OrderBy(b => b.Type).ThenBy(b => b.BasicID);
            //List<SelectListItem> items = new List<SelectListItem>();
            //foreach (var item in resulselect)
            //{
            //    items.Add(new SelectListItem() { Text = item.Name,Value=item.Type });
            //}

            //ViewBag.selectlist = items;
           // var result = new Tuple<IPagedList<Basic>, List<SelectListItem>>(resultlist, items);
            int pageIndex = page ?? 1;
            int pageSize = 10;
            int totalCount = 0;

            totalCount = source.Count();

            source = source.OrderBy(x => x.BasicType)
                           .Skip((pageIndex - 1) * pageSize)
                           .Take(pageSize);

            var pagedResult = new StaticPagedList<KidsGEPT.Models.Basic>(source, pageIndex, pageSize, totalCount);

            return View(pagedResult);
        }

        // GET: backend/Basics/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Basic basic = db.Basic.Find(id);
            if (basic == null)
            {
                return HttpNotFound();
            }
            return View(basic);
        }

        // GET: backend/Basics/Create
        public ActionResult Create()
        
        {
            //選單
            ViewBag.BasicType = this.GetSelectList();
            return View();
        }

        // POST: backend/Basics/Create
        // 若要免於過量張貼攻擊，請啟用想要繫結的特定屬性，如需
        // 詳細資訊，請參閱 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Name,BasicType,val,memo")] Basic basic)
        {
            if (ModelState.IsValid)
            {
                db.Basic.Add(basic);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            //選單    
            ViewBag.BasicType = this.GetSelectList();
            return View(basic);
        }

        // GET: backend/Basics/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Basic basic = db.Basic.Find(id);
            if (basic == null)
            {
                return HttpNotFound();
            }
            ViewBag.BasicType = this.GetSelectList(basic.BasicType);
            return View(basic);
        }

        // POST: backend/Basics/Edit/5
        // 若要免於過量張貼攻擊，請啟用想要繫結的特定屬性，如需
        // 詳細資訊，請參閱 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BasicID,BasicType,Name,val,memo")] Basic basic)
        {
           // basic.Updatedt = db.Database.SqlQuery<DateTime>("SELECT getdate()").First();
            if (ModelState.IsValid)
            {          
                //GenericRepository<Basic> Scheduledb = new GenericRepository<Basic>(db);
                //db = (KidsGEPTEntities)Scheduledb.Updatedb(db.Entry(basic)); 
                db.Entry(basic).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.BasicType = this.GetSelectList(basic.BasicType);
            return View(basic);
        }

        // GET: backend/Basics/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Basic basic = db.Basic.Find(id);
            if (basic == null)
            {
                return HttpNotFound();
            }
            db.Basic.Remove(basic);
            //db.SaveChanges();
            return RedirectToAction("Index");
        }

        // POST: backend/Basics/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Basic basic = db.Basic.Find(id);
            db.Basic.Remove(basic);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
        /// <summary>
        /// 下拉選單
        /// </summary>
        /// <param name="selected"></param>
        /// <returns></returns>
        private dynamic GetSelectList(string selected = null)
        {
            GenericRepository<Basic> Scheduledb = new GenericRepository<Basic>(db);
            return this.GetSelectList(Scheduledb.ToSelectitem(filter: x => x.BasicType == "Basic", toselect: x => new SelectListModelcs { Name = x.Name, Val = x.val }), selected);
        }
    }
}
