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
    public class HalloweensController : Controller
    {
        private CIS_264_Price_APPContext db = new CIS_264_Price_APPContext();

        // GET: Halloweens
        public ActionResult Index()
        {
            return View(db.Halloweens.ToList());
        }

        // GET: Halloweens/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Halloween halloween = db.Halloweens.Find(id);
            if (halloween == null)
            {
                return HttpNotFound();
            }
            return View(halloween);
        }

        // GET: Halloweens/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Halloweens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Halloween_ID,Category,Name,Price,Details")] Halloween halloween)
        {
            if (ModelState.IsValid)
            {
                db.Halloweens.Add(halloween);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(halloween);
        }

        // GET: Halloweens/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Halloween halloween = db.Halloweens.Find(id);
            if (halloween == null)
            {
                return HttpNotFound();
            }
            return View(halloween);
        }

        // POST: Halloweens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Halloween_ID,Category,Name,Price,Details")] Halloween halloween)
        {
            if (ModelState.IsValid)
            {
                db.Entry(halloween).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(halloween);
        }

        // GET: Halloweens/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Halloween halloween = db.Halloweens.Find(id);
            if (halloween == null)
            {
                return HttpNotFound();
            }
            return View(halloween);
        }

        // POST: Halloweens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Halloween halloween = db.Halloweens.Find(id);
            db.Halloweens.Remove(halloween);
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
