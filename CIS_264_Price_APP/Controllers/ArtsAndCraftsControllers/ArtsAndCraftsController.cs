using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CIS_264_Price_APP.Data;
using CIS_264_Price_APP.Models.Arts_Crafts;

namespace CIS_264_Price_APP.Controllers.ArtsAndCraftsControllers
{
    public class ArtsAndCraftsController : Controller
    {
        private CIS_264_Price_APPContext db = new CIS_264_Price_APPContext();

        // GET: ArtsAndCrafts
        public ActionResult Index()
        {
            return View(db.ArtsAndCrafts.ToList());
        }

        // GET: ArtsAndCrafts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ArtsAndCrafts artsAndCrafts = db.ArtsAndCrafts.Find(id);
            if (artsAndCrafts == null)
            {
                return HttpNotFound();
            }
            return View(artsAndCrafts);
        }

        // GET: ArtsAndCrafts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ArtsAndCrafts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ArtsAndCraftsID,Name")] ArtsAndCrafts artsAndCrafts)
        {
            if (ModelState.IsValid)
            {
                db.ArtsAndCrafts.Add(artsAndCrafts);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(artsAndCrafts);
        }

        // GET: ArtsAndCrafts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ArtsAndCrafts artsAndCrafts = db.ArtsAndCrafts.Find(id);
            if (artsAndCrafts == null)
            {
                return HttpNotFound();
            }
            return View(artsAndCrafts);
        }

        // POST: ArtsAndCrafts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ArtsAndCraftsID,Name")] ArtsAndCrafts artsAndCrafts)
        {
            if (ModelState.IsValid)
            {
                db.Entry(artsAndCrafts).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(artsAndCrafts);
        }

        // GET: ArtsAndCrafts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ArtsAndCrafts artsAndCrafts = db.ArtsAndCrafts.Find(id);
            if (artsAndCrafts == null)
            {
                return HttpNotFound();
            }
            return View(artsAndCrafts);
        }

        // POST: ArtsAndCrafts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ArtsAndCrafts artsAndCrafts = db.ArtsAndCrafts.Find(id);
            db.ArtsAndCrafts.Remove(artsAndCrafts);
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
