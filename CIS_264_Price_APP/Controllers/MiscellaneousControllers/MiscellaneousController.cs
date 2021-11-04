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
    public class MiscellaneousController : Controller
    {
        private CIS_264_Price_APPContext db = new CIS_264_Price_APPContext();

        // GET: Miscellaneous
        public ActionResult Index()
        {
            return View(db.Miscellaneous.ToList());
        }

        // GET: Miscellaneous/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Miscellaneous miscellaneous = db.Miscellaneous.Find(id);
            if (miscellaneous == null)
            {
                return HttpNotFound();
            }
            return View(miscellaneous);
        }

        // GET: Miscellaneous/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Miscellaneous/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MiscID,Name")] Miscellaneous miscellaneous)
        {
            if (ModelState.IsValid)
            {
                db.Miscellaneous.Add(miscellaneous);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(miscellaneous);
        }

        // GET: Miscellaneous/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Miscellaneous miscellaneous = db.Miscellaneous.Find(id);
            if (miscellaneous == null)
            {
                return HttpNotFound();
            }
            return View(miscellaneous);
        }

        // POST: Miscellaneous/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MiscID,Name")] Miscellaneous miscellaneous)
        {
            if (ModelState.IsValid)
            {
                db.Entry(miscellaneous).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(miscellaneous);
        }

        // GET: Miscellaneous/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Miscellaneous miscellaneous = db.Miscellaneous.Find(id);
            if (miscellaneous == null)
            {
                return HttpNotFound();
            }
            return View(miscellaneous);
        }

        // POST: Miscellaneous/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Miscellaneous miscellaneous = db.Miscellaneous.Find(id);
            db.Miscellaneous.Remove(miscellaneous);
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
