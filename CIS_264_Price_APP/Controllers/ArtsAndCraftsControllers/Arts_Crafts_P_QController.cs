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
    public class Arts_Crafts_P_QController : Controller
    {
        private CIS_264_Price_APPContext db = new CIS_264_Price_APPContext();

        // GET: Arts_Crafts_P_Q
        public ActionResult Index()
        {
            return View(db.Arts_Crafts_P_Q.ToList());
        }

        // GET: Arts_Crafts_P_Q/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Arts_Crafts_P_Q arts_Crafts_P_Q = db.Arts_Crafts_P_Q.Find(id);
            if (arts_Crafts_P_Q == null)
            {
                return HttpNotFound();
            }
            return View(arts_Crafts_P_Q);
        }

        // GET: Arts_Crafts_P_Q/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Arts_Crafts_P_Q/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Arts_Crafts_P_Q_ID,Category,Name,Price,Details")] Arts_Crafts_P_Q arts_Crafts_P_Q)
        {
            if (ModelState.IsValid)
            {
                db.Arts_Crafts_P_Q.Add(arts_Crafts_P_Q);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(arts_Crafts_P_Q);
        }

        // GET: Arts_Crafts_P_Q/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Arts_Crafts_P_Q arts_Crafts_P_Q = db.Arts_Crafts_P_Q.Find(id);
            if (arts_Crafts_P_Q == null)
            {
                return HttpNotFound();
            }
            return View(arts_Crafts_P_Q);
        }

        // POST: Arts_Crafts_P_Q/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Arts_Crafts_P_Q_ID,Category,Name,Price,Details")] Arts_Crafts_P_Q arts_Crafts_P_Q)
        {
            if (ModelState.IsValid)
            {
                db.Entry(arts_Crafts_P_Q).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(arts_Crafts_P_Q);
        }

        // GET: Arts_Crafts_P_Q/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Arts_Crafts_P_Q arts_Crafts_P_Q = db.Arts_Crafts_P_Q.Find(id);
            if (arts_Crafts_P_Q == null)
            {
                return HttpNotFound();
            }
            return View(arts_Crafts_P_Q);
        }

        // POST: Arts_Crafts_P_Q/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Arts_Crafts_P_Q arts_Crafts_P_Q = db.Arts_Crafts_P_Q.Find(id);
            db.Arts_Crafts_P_Q.Remove(arts_Crafts_P_Q);
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
