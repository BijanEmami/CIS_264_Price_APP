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
    public class XmasandNewYearsController : Controller
    {
        private CIS_264_Price_APPContext db = new CIS_264_Price_APPContext();

        // GET: XmasandNewYears
        public ActionResult Index()
        {
            return View(db.XmasandNewYears.ToList());
        }

        // GET: XmasandNewYears/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            XmasandNewYear xmasandNewYear = db.XmasandNewYears.Find(id);
            if (xmasandNewYear == null)
            {
                return HttpNotFound();
            }
            return View(xmasandNewYear);
        }

        // GET: XmasandNewYears/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: XmasandNewYears/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "XmasandNewYear_ID,Category,Name,Price")] XmasandNewYear xmasandNewYear)
        {
            if (ModelState.IsValid)
            {
                db.XmasandNewYears.Add(xmasandNewYear);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(xmasandNewYear);
        }

        // GET: XmasandNewYears/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            XmasandNewYear xmasandNewYear = db.XmasandNewYears.Find(id);
            if (xmasandNewYear == null)
            {
                return HttpNotFound();
            }
            return View(xmasandNewYear);
        }

        // POST: XmasandNewYears/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "XmasandNewYear_ID,Category,Name,Price")] XmasandNewYear xmasandNewYear)
        {
            if (ModelState.IsValid)
            {
                db.Entry(xmasandNewYear).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(xmasandNewYear);
        }

        // GET: XmasandNewYears/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            XmasandNewYear xmasandNewYear = db.XmasandNewYears.Find(id);
            if (xmasandNewYear == null)
            {
                return HttpNotFound();
            }
            return View(xmasandNewYear);
        }

        // POST: XmasandNewYears/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            XmasandNewYear xmasandNewYear = db.XmasandNewYears.Find(id);
            db.XmasandNewYears.Remove(xmasandNewYear);
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
