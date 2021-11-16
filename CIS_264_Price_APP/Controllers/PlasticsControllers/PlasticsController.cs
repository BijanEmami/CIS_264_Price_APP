using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CIS_264_Price_APP.Data;
using CIS_264_Price_APP.Models.Plastics;

namespace CIS_264_Price_APP.Controllers.PlasticsControllers
{
    public class PlasticsController : Controller
    {
        private CIS_264_Price_APPContext db = new CIS_264_Price_APPContext();

        // GET: Plastics
        public ActionResult Index()
        {
            return View(db.Plastics.ToList());
        }

        // GET: Plastics/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Plastics plastics = db.Plastics.Find(id);
            if (plastics == null)
            {
                return HttpNotFound();
            }
            return View(plastics);
        }

        // GET: Plastics/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Plastics/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Holidays_ID,Name")] Plastics plastics)
        {
            if (ModelState.IsValid)
            {
                db.Plastics.Add(plastics);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(plastics);
        }

        // GET: Plastics/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Plastics plastics = db.Plastics.Find(id);
            if (plastics == null)
            {
                return HttpNotFound();
            }
            return View(plastics);
        }

        // POST: Plastics/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Holidays_ID,Name")] Plastics plastics)
        {
            if (ModelState.IsValid)
            {
                db.Entry(plastics).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(plastics);
        }

        // GET: Plastics/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Plastics plastics = db.Plastics.Find(id);
            if (plastics == null)
            {
                return HttpNotFound();
            }
            return View(plastics);
        }

        // POST: Plastics/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Plastics plastics = db.Plastics.Find(id);
            db.Plastics.Remove(plastics);
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
