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
    public class Misc_T_ZController : Controller
    {
        private CIS_264_Price_APPContext db = new CIS_264_Price_APPContext();

        // GET: Misc_T_Z
        public ActionResult Index()
        {
            return View(db.Misc_T_Z.ToList());
        }

        // GET: Misc_T_Z/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Misc_T_Z misc_T_Z = db.Misc_T_Z.Find(id);
            if (misc_T_Z == null)
            {
                return HttpNotFound();
            }
            return View(misc_T_Z);
        }

        // GET: Misc_T_Z/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Misc_T_Z/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Misc_T_Z_ID,Category,Name,Price")] Misc_T_Z misc_T_Z)
        {
            if (ModelState.IsValid)
            {
                db.Misc_T_Z.Add(misc_T_Z);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(misc_T_Z);
        }

        // GET: Misc_T_Z/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Misc_T_Z misc_T_Z = db.Misc_T_Z.Find(id);
            if (misc_T_Z == null)
            {
                return HttpNotFound();
            }
            return View(misc_T_Z);
        }

        // POST: Misc_T_Z/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Misc_T_Z_ID,Category,Name,Price")] Misc_T_Z misc_T_Z)
        {
            if (ModelState.IsValid)
            {
                db.Entry(misc_T_Z).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(misc_T_Z);
        }

        // GET: Misc_T_Z/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Misc_T_Z misc_T_Z = db.Misc_T_Z.Find(id);
            if (misc_T_Z == null)
            {
                return HttpNotFound();
            }
            return View(misc_T_Z);
        }

        // POST: Misc_T_Z/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Misc_T_Z misc_T_Z = db.Misc_T_Z.Find(id);
            db.Misc_T_Z.Remove(misc_T_Z);
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
