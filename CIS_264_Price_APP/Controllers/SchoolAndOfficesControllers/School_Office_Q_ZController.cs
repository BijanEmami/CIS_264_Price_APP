using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CIS_264_Price_APP.Data;
using CIS_264_Price_APP.Models.School_Office;

namespace CIS_264_Price_APP.Controllers.SchoolAndOfficesControllers
{
    public class School_Office_Q_ZController : Controller
    {
        private CIS_264_Price_APPContext db = new CIS_264_Price_APPContext();

        // GET: School_Office_Q_Z
        public ActionResult Index()
        {
            return View(db.School_Office_Q_Z.ToList());
        }

        // GET: School_Office_Q_Z/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            School_Office_Q_Z school_Office_Q_Z = db.School_Office_Q_Z.Find(id);
            if (school_Office_Q_Z == null)
            {
                return HttpNotFound();
            }
            return View(school_Office_Q_Z);
        }

        // GET: School_Office_Q_Z/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: School_Office_Q_Z/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "School_Office_Q_Z_ID,Category,Name,Price,Details")] School_Office_Q_Z school_Office_Q_Z)
        {
            if (ModelState.IsValid)
            {
                db.School_Office_Q_Z.Add(school_Office_Q_Z);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(school_Office_Q_Z);
        }

        // GET: School_Office_Q_Z/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            School_Office_Q_Z school_Office_Q_Z = db.School_Office_Q_Z.Find(id);
            if (school_Office_Q_Z == null)
            {
                return HttpNotFound();
            }
            return View(school_Office_Q_Z);
        }

        // POST: School_Office_Q_Z/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "School_Office_Q_Z_ID,Category,Name,Price,Details")] School_Office_Q_Z school_Office_Q_Z)
        {
            if (ModelState.IsValid)
            {
                db.Entry(school_Office_Q_Z).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(school_Office_Q_Z);
        }

        // GET: School_Office_Q_Z/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            School_Office_Q_Z school_Office_Q_Z = db.School_Office_Q_Z.Find(id);
            if (school_Office_Q_Z == null)
            {
                return HttpNotFound();
            }
            return View(school_Office_Q_Z);
        }

        // POST: School_Office_Q_Z/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            School_Office_Q_Z school_Office_Q_Z = db.School_Office_Q_Z.Find(id);
            db.School_Office_Q_Z.Remove(school_Office_Q_Z);
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
