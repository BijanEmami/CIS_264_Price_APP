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
    public class July4thController : Controller
    {
        private CIS_264_Price_APPContext db = new CIS_264_Price_APPContext();

        // GET: July4th
        public ActionResult Index()
        {
            return View(db.July4th.ToList());
        }

        // GET: July4th/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            July4th july4th = db.July4th.Find(id);
            if (july4th == null)
            {
                return HttpNotFound();
            }
            return View(july4th);
        }

        // GET: July4th/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: July4th/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "July4th_ID,Category,Name,Price,Details")] July4th july4th)
        {
            if (ModelState.IsValid)
            {
                db.July4th.Add(july4th);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(july4th);
        }

        // GET: July4th/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            July4th july4th = db.July4th.Find(id);
            if (july4th == null)
            {
                return HttpNotFound();
            }
            return View(july4th);
        }

        // POST: July4th/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "July4th_ID,Category,Name,Price,Details")] July4th july4th)
        {
            if (ModelState.IsValid)
            {
                db.Entry(july4th).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(july4th);
        }

        // GET: July4th/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            July4th july4th = db.July4th.Find(id);
            if (july4th == null)
            {
                return HttpNotFound();
            }
            return View(july4th);
        }

        // POST: July4th/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            July4th july4th = db.July4th.Find(id);
            db.July4th.Remove(july4th);
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
