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
    public class Textiles_D_NController : Controller
    {
        private CIS_264_Price_APPContext db = new CIS_264_Price_APPContext();

        // GET: Textiles_D_N
        public ActionResult Index()
        {
            return View(db.Textiles_D_N.ToList());
        }

        // GET: Textiles_D_N/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Textiles_D_N textiles_D_N = db.Textiles_D_N.Find(id);
            if (textiles_D_N == null)
            {
                return HttpNotFound();
            }
            return View(textiles_D_N);
        }

        // GET: Textiles_D_N/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Textiles_D_N/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Textiles_D_N_ID,Category,Name,Price,Details")] Textiles_D_N textiles_D_N)
        {
            if (ModelState.IsValid)
            {
                db.Textiles_D_N.Add(textiles_D_N);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(textiles_D_N);
        }

        // GET: Textiles_D_N/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Textiles_D_N textiles_D_N = db.Textiles_D_N.Find(id);
            if (textiles_D_N == null)
            {
                return HttpNotFound();
            }
            return View(textiles_D_N);
        }

        // POST: Textiles_D_N/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Textiles_D_N_ID,Category,Name,Price,Details")] Textiles_D_N textiles_D_N)
        {
            if (ModelState.IsValid)
            {
                db.Entry(textiles_D_N).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(textiles_D_N);
        }

        // GET: Textiles_D_N/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Textiles_D_N textiles_D_N = db.Textiles_D_N.Find(id);
            if (textiles_D_N == null)
            {
                return HttpNotFound();
            }
            return View(textiles_D_N);
        }

        // POST: Textiles_D_N/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Textiles_D_N textiles_D_N = db.Textiles_D_N.Find(id);
            db.Textiles_D_N.Remove(textiles_D_N);
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
