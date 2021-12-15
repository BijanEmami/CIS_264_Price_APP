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
    public class Textiles_T_VController : Controller
    {
        private CIS_264_Price_APPContext db = new CIS_264_Price_APPContext();

        // GET: Textiles_T_V
        public ActionResult Index()
        {
            return View(db.Textiles_T_V.ToList());
        }

        // GET: Textiles_T_V/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Textiles_T_V textiles_T_V = db.Textiles_T_V.Find(id);
            if (textiles_T_V == null)
            {
                return HttpNotFound();
            }
            return View(textiles_T_V);
        }

        // GET: Textiles_T_V/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Textiles_T_V/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Textiles_T_V_ID,Category,Name,Price,Details")] Textiles_T_V textiles_T_V)
        {
            if (ModelState.IsValid)
            {
                db.Textiles_T_V.Add(textiles_T_V);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(textiles_T_V);
        }

        // GET: Textiles_T_V/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Textiles_T_V textiles_T_V = db.Textiles_T_V.Find(id);
            if (textiles_T_V == null)
            {
                return HttpNotFound();
            }
            return View(textiles_T_V);
        }

        // POST: Textiles_T_V/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Textiles_T_V_ID,Category,Name,Price,Details")] Textiles_T_V textiles_T_V)
        {
            if (ModelState.IsValid)
            {
                db.Entry(textiles_T_V).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(textiles_T_V);
        }

        // GET: Textiles_T_V/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Textiles_T_V textiles_T_V = db.Textiles_T_V.Find(id);
            if (textiles_T_V == null)
            {
                return HttpNotFound();
            }
            return View(textiles_T_V);
        }

        // POST: Textiles_T_V/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Textiles_T_V textiles_T_V = db.Textiles_T_V.Find(id);
            db.Textiles_T_V.Remove(textiles_T_V);
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
