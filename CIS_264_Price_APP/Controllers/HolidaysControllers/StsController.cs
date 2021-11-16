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
    public class StsController : Controller
    {
        private CIS_264_Price_APPContext db = new CIS_264_Price_APPContext();

        // GET: Sts
        public ActionResult Index()
        {
            return View(db.Sts.ToList());
        }

        // GET: Sts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            St st = db.Sts.Find(id);
            if (st == null)
            {
                return HttpNotFound();
            }
            return View(st);
        }

        // GET: Sts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "St_ID,Category,Name,Price")] St st)
        {
            if (ModelState.IsValid)
            {
                db.Sts.Add(st);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(st);
        }

        // GET: Sts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            St st = db.Sts.Find(id);
            if (st == null)
            {
                return HttpNotFound();
            }
            return View(st);
        }

        // POST: Sts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "St_ID,Category,Name,Price")] St st)
        {
            if (ModelState.IsValid)
            {
                db.Entry(st).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(st);
        }

        // GET: Sts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            St st = db.Sts.Find(id);
            if (st == null)
            {
                return HttpNotFound();
            }
            return View(st);
        }

        // POST: Sts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            St st = db.Sts.Find(id);
            db.Sts.Remove(st);
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
