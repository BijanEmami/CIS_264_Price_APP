using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CIS_264_Price_APP.Data;
using CIS_264_Price_APP.Models.Textiles;

namespace CIS_264_Price_APP.Controllers.TextilesControllers
{
    public class Textiles_W_ZController : Controller
    {
        private CIS_264_Price_APPContext db = new CIS_264_Price_APPContext();

        // GET: Textiles_W_Z
        public ActionResult Index()
        {
            return View(db.Textiles_W_Z.ToList());
        }

        // GET: Textiles_W_Z/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Textiles_W_Z textiles_W_Z = db.Textiles_W_Z.Find(id);
            if (textiles_W_Z == null)
            {
                return HttpNotFound();
            }
            return View(textiles_W_Z);
        }

        // GET: Textiles_W_Z/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Textiles_W_Z/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Textiles_W_Z_ID,Category,Name,Price")] Textiles_W_Z textiles_W_Z)
        {
            if (ModelState.IsValid)
            {
                db.Textiles_W_Z.Add(textiles_W_Z);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(textiles_W_Z);
        }

        // GET: Textiles_W_Z/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Textiles_W_Z textiles_W_Z = db.Textiles_W_Z.Find(id);
            if (textiles_W_Z == null)
            {
                return HttpNotFound();
            }
            return View(textiles_W_Z);
        }

        // POST: Textiles_W_Z/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Textiles_W_Z_ID,Category,Name,Price")] Textiles_W_Z textiles_W_Z)
        {
            if (ModelState.IsValid)
            {
                db.Entry(textiles_W_Z).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(textiles_W_Z);
        }

        // GET: Textiles_W_Z/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Textiles_W_Z textiles_W_Z = db.Textiles_W_Z.Find(id);
            if (textiles_W_Z == null)
            {
                return HttpNotFound();
            }
            return View(textiles_W_Z);
        }

        // POST: Textiles_W_Z/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Textiles_W_Z textiles_W_Z = db.Textiles_W_Z.Find(id);
            db.Textiles_W_Z.Remove(textiles_W_Z);
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
