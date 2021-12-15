using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CIS_264_Price_APP.Data;
using CIS_264_Price_APP.Models.Misc;

namespace CIS_264_Price_APP.Controllers.MiscellaneousControllers
{
    public class Misc_PController : Controller
    {
        private CIS_264_Price_APPContext db = new CIS_264_Price_APPContext();

        // GET: Misc_P
        public ActionResult Index()
        {
            return View(db.Misc_P.ToList());
        }

        // GET: Misc_P/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Misc_P misc_P = db.Misc_P.Find(id);
            if (misc_P == null)
            {
                return HttpNotFound();
            }
            return View(misc_P);
        }

        // GET: Misc_P/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Misc_P/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Misc_P_ID,Category,Name,Price,Details")] Misc_P misc_P)
        {
            if (ModelState.IsValid)
            {
                db.Misc_P.Add(misc_P);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(misc_P);
        }

        // GET: Misc_P/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Misc_P misc_P = db.Misc_P.Find(id);
            if (misc_P == null)
            {
                return HttpNotFound();
            }
            return View(misc_P);
        }

        // POST: Misc_P/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Misc_P_ID,Category,Name,Price,Details")] Misc_P misc_P)
        {
            if (ModelState.IsValid)
            {
                db.Entry(misc_P).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(misc_P);
        }

        // GET: Misc_P/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Misc_P misc_P = db.Misc_P.Find(id);
            if (misc_P == null)
            {
                return HttpNotFound();
            }
            return View(misc_P);
        }

        // POST: Misc_P/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Misc_P misc_P = db.Misc_P.Find(id);
            db.Misc_P.Remove(misc_P);
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
