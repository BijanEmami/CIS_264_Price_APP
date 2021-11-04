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
    public class Misc_G_LController : Controller
    {
        private CIS_264_Price_APPContext db = new CIS_264_Price_APPContext();

        // GET: Misc_G_L
        public ActionResult Index()
        {
            return View(db.Misc_G_L.ToList());
        }

        // GET: Misc_G_L/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Misc_G_L misc_G_L = db.Misc_G_L.Find(id);
            if (misc_G_L == null)
            {
                return HttpNotFound();
            }
            return View(misc_G_L);
        }

        // GET: Misc_G_L/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Misc_G_L/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Misc_G_L_ID,Category,Name,Price")] Misc_G_L misc_G_L)
        {
            if (ModelState.IsValid)
            {
                db.Misc_G_L.Add(misc_G_L);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(misc_G_L);
        }

        // GET: Misc_G_L/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Misc_G_L misc_G_L = db.Misc_G_L.Find(id);
            if (misc_G_L == null)
            {
                return HttpNotFound();
            }
            return View(misc_G_L);
        }

        // POST: Misc_G_L/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Misc_G_L_ID,Category,Name,Price")] Misc_G_L misc_G_L)
        {
            if (ModelState.IsValid)
            {
                db.Entry(misc_G_L).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(misc_G_L);
        }

        // GET: Misc_G_L/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Misc_G_L misc_G_L = db.Misc_G_L.Find(id);
            if (misc_G_L == null)
            {
                return HttpNotFound();
            }
            return View(misc_G_L);
        }

        // POST: Misc_G_L/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Misc_G_L misc_G_L = db.Misc_G_L.Find(id);
            db.Misc_G_L.Remove(misc_G_L);
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
