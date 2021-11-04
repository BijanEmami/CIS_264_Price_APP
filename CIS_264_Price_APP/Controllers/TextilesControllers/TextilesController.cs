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
    public class TextilesController : Controller
    {
        private CIS_264_Price_APPContext db = new CIS_264_Price_APPContext();

        // GET: Textiles
        public ActionResult Index()
        {
            return View(db.Textiles.ToList());
        }

        // GET: Textiles/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Textiles textiles = db.Textiles.Find(id);
            if (textiles == null)
            {
                return HttpNotFound();
            }
            return View(textiles);
        }

        // GET: Textiles/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Textiles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TextilesID,Name")] Textiles textiles)
        {
            if (ModelState.IsValid)
            {
                db.Textiles.Add(textiles);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(textiles);
        }

        // GET: Textiles/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Textiles textiles = db.Textiles.Find(id);
            if (textiles == null)
            {
                return HttpNotFound();
            }
            return View(textiles);
        }

        // POST: Textiles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TextilesID,Name")] Textiles textiles)
        {
            if (ModelState.IsValid)
            {
                db.Entry(textiles).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(textiles);
        }

        // GET: Textiles/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Textiles textiles = db.Textiles.Find(id);
            if (textiles == null)
            {
                return HttpNotFound();
            }
            return View(textiles);
        }

        // POST: Textiles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Textiles textiles = db.Textiles.Find(id);
            db.Textiles.Remove(textiles);
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
