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
    public class School_Office_C_DController : Controller
    {
        private CIS_264_Price_APPContext db = new CIS_264_Price_APPContext();

        // GET: School_Office_C_D
        public ActionResult Index()
        {
            return View(db.School_Office_C_D.ToList());
        }

        // GET: School_Office_C_D/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            School_Office_C_D school_Office_C_D = db.School_Office_C_D.Find(id);
            if (school_Office_C_D == null)
            {
                return HttpNotFound();
            }
            return View(school_Office_C_D);
        }

        // GET: School_Office_C_D/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: School_Office_C_D/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "School_Office_C_D_ID,Category,Name,Price")] School_Office_C_D school_Office_C_D)
        {
            if (ModelState.IsValid)
            {
                db.School_Office_C_D.Add(school_Office_C_D);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(school_Office_C_D);
        }

        // GET: School_Office_C_D/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            School_Office_C_D school_Office_C_D = db.School_Office_C_D.Find(id);
            if (school_Office_C_D == null)
            {
                return HttpNotFound();
            }
            return View(school_Office_C_D);
        }

        // POST: School_Office_C_D/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "School_Office_C_D_ID,Category,Name,Price")] School_Office_C_D school_Office_C_D)
        {
            if (ModelState.IsValid)
            {
                db.Entry(school_Office_C_D).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(school_Office_C_D);
        }

        // GET: School_Office_C_D/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            School_Office_C_D school_Office_C_D = db.School_Office_C_D.Find(id);
            if (school_Office_C_D == null)
            {
                return HttpNotFound();
            }
            return View(school_Office_C_D);
        }

        // POST: School_Office_C_D/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            School_Office_C_D school_Office_C_D = db.School_Office_C_D.Find(id);
            db.School_Office_C_D.Remove(school_Office_C_D);
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
