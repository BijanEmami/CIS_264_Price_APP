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
    public class Arts_Crafts_A_CController : Controller
    {
        private CIS_264_Price_APPContext db = new CIS_264_Price_APPContext();

        // GET: Arts_Crafts_A_C
        public ActionResult Index()
        {
            return View(db.Arts_Crafts_A_C.ToList());
        }

        // GET: Arts_Crafts_A_C/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Arts_Crafts_A_C arts_Crafts_A_C = db.Arts_Crafts_A_C.Find(id);
            if (arts_Crafts_A_C == null)
            {
                return HttpNotFound();
            }
            return View(arts_Crafts_A_C);
        }

        // GET: Arts_Crafts_A_C/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Arts_Crafts_A_C/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Arts_Crafts_A_C_ID,Category,Name,Price,Details")] Arts_Crafts_A_C arts_Crafts_A_C)
        {
            if (ModelState.IsValid)
            {
                db.Arts_Crafts_A_C.Add(arts_Crafts_A_C);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(arts_Crafts_A_C);
        }

        // GET: Arts_Crafts_A_C/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Arts_Crafts_A_C arts_Crafts_A_C = db.Arts_Crafts_A_C.Find(id);
            if (arts_Crafts_A_C == null)
            {
                return HttpNotFound();
            }
            return View(arts_Crafts_A_C);
        }

        // POST: Arts_Crafts_A_C/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Arts_Crafts_A_C_ID,Category,Name,Price,Details")] Arts_Crafts_A_C arts_Crafts_A_C)
        {
            if (ModelState.IsValid)
            {
                db.Entry(arts_Crafts_A_C).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(arts_Crafts_A_C);
        }

        // GET: Arts_Crafts_A_C/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Arts_Crafts_A_C arts_Crafts_A_C = db.Arts_Crafts_A_C.Find(id);
            if (arts_Crafts_A_C == null)
            {
                return HttpNotFound();
            }
            return View(arts_Crafts_A_C);
        }

        // POST: Arts_Crafts_A_C/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Arts_Crafts_A_C arts_Crafts_A_C = db.Arts_Crafts_A_C.Find(id);
            db.Arts_Crafts_A_C.Remove(arts_Crafts_A_C);
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
