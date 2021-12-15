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
    public class Misc_Q_SController : Controller
    {
        private CIS_264_Price_APPContext db = new CIS_264_Price_APPContext();

        // GET: Misc_Q_S
        public ActionResult Index()
        {
            return View(db.Misc_Q_S.ToList());
        }

        // GET: Misc_Q_S/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Misc_Q_S misc_Q_S = db.Misc_Q_S.Find(id);
            if (misc_Q_S == null)
            {
                return HttpNotFound();
            }
            return View(misc_Q_S);
        }

        // GET: Misc_Q_S/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Misc_Q_S/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Misc_Q_S_ID,Category,Name,Price,Details")] Misc_Q_S misc_Q_S)
        {
            if (ModelState.IsValid)
            {
                db.Misc_Q_S.Add(misc_Q_S);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(misc_Q_S);
        }

        // GET: Misc_Q_S/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Misc_Q_S misc_Q_S = db.Misc_Q_S.Find(id);
            if (misc_Q_S == null)
            {
                return HttpNotFound();
            }
            return View(misc_Q_S);
        }

        // POST: Misc_Q_S/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Misc_Q_S_ID,Category,Name,Price,Details")] Misc_Q_S misc_Q_S)
        {
            if (ModelState.IsValid)
            {
                db.Entry(misc_Q_S).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(misc_Q_S);
        }

        // GET: Misc_Q_S/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Misc_Q_S misc_Q_S = db.Misc_Q_S.Find(id);
            if (misc_Q_S == null)
            {
                return HttpNotFound();
            }
            return View(misc_Q_S);
        }

        // POST: Misc_Q_S/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Misc_Q_S misc_Q_S = db.Misc_Q_S.Find(id);
            db.Misc_Q_S.Remove(misc_Q_S);
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
