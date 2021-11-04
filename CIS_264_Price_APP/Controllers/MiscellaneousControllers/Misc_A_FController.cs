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
    public class Misc_A_FController : Controller
    {
        private CIS_264_Price_APPContext db = new CIS_264_Price_APPContext();

        // GET: Misc_A_F
        public ActionResult Index()
        {
            return View(db.Misc_A_F.ToList());
        }

        // GET: Misc_A_F/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Misc_A_F misc_A_F = db.Misc_A_F.Find(id);
            if (misc_A_F == null)
            {
                return HttpNotFound();
            }
            return View(misc_A_F);
        }

        // GET: Misc_A_F/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Misc_A_F/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Misc_A_F_ID,Category,Name,Price")] Misc_A_F misc_A_F)
        {
            if (ModelState.IsValid)
            {
                db.Misc_A_F.Add(misc_A_F);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(misc_A_F);
        }

        // GET: Misc_A_F/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Misc_A_F misc_A_F = db.Misc_A_F.Find(id);
            if (misc_A_F == null)
            {
                return HttpNotFound();
            }
            return View(misc_A_F);
        }

        // POST: Misc_A_F/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Misc_A_F_ID,Category,Name,Price")] Misc_A_F misc_A_F)
        {
            if (ModelState.IsValid)
            {
                db.Entry(misc_A_F).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(misc_A_F);
        }

        // GET: Misc_A_F/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Misc_A_F misc_A_F = db.Misc_A_F.Find(id);
            if (misc_A_F == null)
            {
                return HttpNotFound();
            }
            return View(misc_A_F);
        }

        // POST: Misc_A_F/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Misc_A_F misc_A_F = db.Misc_A_F.Find(id);
            db.Misc_A_F.Remove(misc_A_F);
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
