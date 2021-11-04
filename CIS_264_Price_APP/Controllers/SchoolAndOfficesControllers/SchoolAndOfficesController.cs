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
    public class SchoolAndOfficesController : Controller
    {
        private CIS_264_Price_APPContext db = new CIS_264_Price_APPContext();

        // GET: SchoolAndOffices
        public ActionResult Index()
        {
            return View(db.SchoolAndOffices.ToList());
        }

        // GET: SchoolAndOffices/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SchoolAndOffice schoolAndOffice = db.SchoolAndOffices.Find(id);
            if (schoolAndOffice == null)
            {
                return HttpNotFound();
            }
            return View(schoolAndOffice);
        }

        // GET: SchoolAndOffices/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SchoolAndOffices/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SchoolAndOfficeID,Name")] SchoolAndOffice schoolAndOffice)
        {
            if (ModelState.IsValid)
            {
                db.SchoolAndOffices.Add(schoolAndOffice);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(schoolAndOffice);
        }

        // GET: SchoolAndOffices/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SchoolAndOffice schoolAndOffice = db.SchoolAndOffices.Find(id);
            if (schoolAndOffice == null)
            {
                return HttpNotFound();
            }
            return View(schoolAndOffice);
        }

        // POST: SchoolAndOffices/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SchoolAndOfficeID,Name")] SchoolAndOffice schoolAndOffice)
        {
            if (ModelState.IsValid)
            {
                db.Entry(schoolAndOffice).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(schoolAndOffice);
        }

        // GET: SchoolAndOffices/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SchoolAndOffice schoolAndOffice = db.SchoolAndOffices.Find(id);
            if (schoolAndOffice == null)
            {
                return HttpNotFound();
            }
            return View(schoolAndOffice);
        }

        // POST: SchoolAndOffices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SchoolAndOffice schoolAndOffice = db.SchoolAndOffices.Find(id);
            db.SchoolAndOffices.Remove(schoolAndOffice);
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
