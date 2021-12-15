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
    public class Textiles_A_CController : Controller
    {
        private CIS_264_Price_APPContext db = new CIS_264_Price_APPContext();

        // GET: Textiles_A_C
        public ActionResult Index()
        {
            return View(db.Textiles_A_C.ToList());
        }

        // GET: Textiles_A_C/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Textiles_A_C textiles_A_C = db.Textiles_A_C.Find(id);
            if (textiles_A_C == null)
            {
                return HttpNotFound();
            }
            return View(textiles_A_C);
        }

        // GET: Textiles_A_C/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Textiles_A_C/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Textiles_A_C_ID,Category,Name,Price,Details")] Textiles_A_C textiles_A_C)
        {
            if (ModelState.IsValid)
            {
                db.Textiles_A_C.Add(textiles_A_C);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(textiles_A_C);
        }

        // GET: Textiles_A_C/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Textiles_A_C textiles_A_C = db.Textiles_A_C.Find(id);
            if (textiles_A_C == null)
            {
                return HttpNotFound();
            }
            return View(textiles_A_C);
        }

        // POST: Textiles_A_C/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Textiles_A_C_ID,Category,Name,Price,Details")] Textiles_A_C textiles_A_C)
        {
            if (ModelState.IsValid)
            {
                db.Entry(textiles_A_C).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(textiles_A_C);
        }

        // GET: Textiles_A_C/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Textiles_A_C textiles_A_C = db.Textiles_A_C.Find(id);
            if (textiles_A_C == null)
            {
                return HttpNotFound();
            }
            return View(textiles_A_C);
        }

        // POST: Textiles_A_C/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Textiles_A_C textiles_A_C = db.Textiles_A_C.Find(id);
            db.Textiles_A_C.Remove(textiles_A_C);
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
