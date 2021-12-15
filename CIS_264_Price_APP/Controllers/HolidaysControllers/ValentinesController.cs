using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CIS_264_Price_APP.Data;
using CIS_264_Price_APP.Models.Holidays;

namespace CIS_264_Price_APP.Controllers.HolidaysControllers
{
    public class ValentinesController : Controller
    {
        private CIS_264_Price_APPContext db = new CIS_264_Price_APPContext();

        // GET: Valentines
        public ActionResult Index()
        {
            return View(db.Valentines.ToList());
        }

        // GET: Valentines/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Valentines valentines = db.Valentines.Find(id);
            if (valentines == null)
            {
                return HttpNotFound();
            }
            return View(valentines);
        }

        // GET: Valentines/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Valentines/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Valentines_ID,Category,Name,Price,Details")] Valentines valentines)
        {
            if (ModelState.IsValid)
            {
                db.Valentines.Add(valentines);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(valentines);
        }

        // GET: Valentines/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Valentines valentines = db.Valentines.Find(id);
            if (valentines == null)
            {
                return HttpNotFound();
            }
            return View(valentines);
        }

        // POST: Valentines/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Valentines_ID,Category,Name,Price,Details")] Valentines valentines)
        {
            if (ModelState.IsValid)
            {
                db.Entry(valentines).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(valentines);
        }

        // GET: Valentines/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Valentines valentines = db.Valentines.Find(id);
            if (valentines == null)
            {
                return HttpNotFound();
            }
            return View(valentines);
        }

        // POST: Valentines/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Valentines valentines = db.Valentines.Find(id);
            db.Valentines.Remove(valentines);
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
    }
}
