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
    public class Misc_M_OController : Controller
    {
        private CIS_264_Price_APPContext db = new CIS_264_Price_APPContext();

        // GET: Misc_M_O
        public ActionResult Index()
        {
            return View(db.Misc_M_O.ToList());
        }

        // GET: Misc_M_O/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Misc_M_O misc_M_O = db.Misc_M_O.Find(id);
            if (misc_M_O == null)
            {
                return HttpNotFound();
            }
            return View(misc_M_O);
        }

        // GET: Misc_M_O/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Misc_M_O/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Misc_M_O_ID,Category,Name,Price,Details")] Misc_M_O misc_M_O)
        {
            if (ModelState.IsValid)
            {
                db.Misc_M_O.Add(misc_M_O);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(misc_M_O);
        }

        // GET: Misc_M_O/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Misc_M_O misc_M_O = db.Misc_M_O.Find(id);
            if (misc_M_O == null)
            {
                return HttpNotFound();
            }
            return View(misc_M_O);
        }

        // POST: Misc_M_O/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Misc_M_O_ID,Category,Name,Price,Details")] Misc_M_O misc_M_O)
        {
            if (ModelState.IsValid)
            {
                db.Entry(misc_M_O).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(misc_M_O);
        }

        // GET: Misc_M_O/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Misc_M_O misc_M_O = db.Misc_M_O.Find(id);
            if (misc_M_O == null)
            {
                return HttpNotFound();
            }
            return View(misc_M_O);
        }

        // POST: Misc_M_O/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Misc_M_O misc_M_O = db.Misc_M_O.Find(id);
            db.Misc_M_O.Remove(misc_M_O);
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
