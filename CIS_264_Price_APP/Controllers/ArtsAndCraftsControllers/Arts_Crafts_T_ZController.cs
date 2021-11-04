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
    public class Arts_Crafts_T_ZController : Controller
    {
        private CIS_264_Price_APPContext db = new CIS_264_Price_APPContext();

        // GET: Arts_Crafts_T_Z
        public ActionResult Index()
        {
            return View(db.Arts_Crafts_T_Z.ToList());
        }

        // GET: Arts_Crafts_T_Z/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Arts_Crafts_T_Z arts_Crafts_T_Z = db.Arts_Crafts_T_Z.Find(id);
            if (arts_Crafts_T_Z == null)
            {
                return HttpNotFound();
            }
            return View(arts_Crafts_T_Z);
        }

        // GET: Arts_Crafts_T_Z/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Arts_Crafts_T_Z/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Arts_Crafts_T_Z_ID,Category,Name,Price")] Arts_Crafts_T_Z arts_Crafts_T_Z)
        {
            if (ModelState.IsValid)
            {
                db.Arts_Crafts_T_Z.Add(arts_Crafts_T_Z);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(arts_Crafts_T_Z);
        }

        // GET: Arts_Crafts_T_Z/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Arts_Crafts_T_Z arts_Crafts_T_Z = db.Arts_Crafts_T_Z.Find(id);
            if (arts_Crafts_T_Z == null)
            {
                return HttpNotFound();
            }
            return View(arts_Crafts_T_Z);
        }

        // POST: Arts_Crafts_T_Z/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Arts_Crafts_T_Z_ID,Category,Name,Price")] Arts_Crafts_T_Z arts_Crafts_T_Z)
        {
            if (ModelState.IsValid)
            {
                db.Entry(arts_Crafts_T_Z).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(arts_Crafts_T_Z);
        }

        // GET: Arts_Crafts_T_Z/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Arts_Crafts_T_Z arts_Crafts_T_Z = db.Arts_Crafts_T_Z.Find(id);
            if (arts_Crafts_T_Z == null)
            {
                return HttpNotFound();
            }
            return View(arts_Crafts_T_Z);
        }

        // POST: Arts_Crafts_T_Z/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Arts_Crafts_T_Z arts_Crafts_T_Z = db.Arts_Crafts_T_Z.Find(id);
            db.Arts_Crafts_T_Z.Remove(arts_Crafts_T_Z);
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
