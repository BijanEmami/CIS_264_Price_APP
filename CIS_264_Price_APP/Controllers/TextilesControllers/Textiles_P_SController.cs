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
    public class Textiles_P_SController : Controller
    {
        private CIS_264_Price_APPContext db = new CIS_264_Price_APPContext();

        // GET: Textiles_P_S
        public ActionResult Index()
        {
            return View(db.Textiles_P_S.ToList());
        }

        // GET: Textiles_P_S/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Textiles_P_S textiles_P_S = db.Textiles_P_S.Find(id);
            if (textiles_P_S == null)
            {
                return HttpNotFound();
            }
            return View(textiles_P_S);
        }

        // GET: Textiles_P_S/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Textiles_P_S/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Textiles_P_S_ID,Category,Name,Price")] Textiles_P_S textiles_P_S)
        {
            if (ModelState.IsValid)
            {
                db.Textiles_P_S.Add(textiles_P_S);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(textiles_P_S);
        }

        // GET: Textiles_P_S/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Textiles_P_S textiles_P_S = db.Textiles_P_S.Find(id);
            if (textiles_P_S == null)
            {
                return HttpNotFound();
            }
            return View(textiles_P_S);
        }

        // POST: Textiles_P_S/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Textiles_P_S_ID,Category,Name,Price")] Textiles_P_S textiles_P_S)
        {
            if (ModelState.IsValid)
            {
                db.Entry(textiles_P_S).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(textiles_P_S);
        }

        // GET: Textiles_P_S/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Textiles_P_S textiles_P_S = db.Textiles_P_S.Find(id);
            if (textiles_P_S == null)
            {
                return HttpNotFound();
            }
            return View(textiles_P_S);
        }

        // POST: Textiles_P_S/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Textiles_P_S textiles_P_S = db.Textiles_P_S.Find(id);
            db.Textiles_P_S.Remove(textiles_P_S);
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
