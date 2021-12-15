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
    public class Arts_Crafts_R_SController : Controller
    {
        private CIS_264_Price_APPContext db = new CIS_264_Price_APPContext();

        // GET: Arts_Crafts_R_S
        public ActionResult Index()
        {
            return View(db.Arts_Crafts_R_S.ToList());
        }

        // GET: Arts_Crafts_R_S/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Arts_Crafts_R_S arts_Crafts_R_S = db.Arts_Crafts_R_S.Find(id);
            if (arts_Crafts_R_S == null)
            {
                return HttpNotFound();
            }
            return View(arts_Crafts_R_S);
        }

        // GET: Arts_Crafts_R_S/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Arts_Crafts_R_S/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Arts_Crafts_R_S_ID,Category,Name,Price,Details")] Arts_Crafts_R_S arts_Crafts_R_S)
        {
            if (ModelState.IsValid)
            {
                db.Arts_Crafts_R_S.Add(arts_Crafts_R_S);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(arts_Crafts_R_S);
        }

        // GET: Arts_Crafts_R_S/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Arts_Crafts_R_S arts_Crafts_R_S = db.Arts_Crafts_R_S.Find(id);
            if (arts_Crafts_R_S == null)
            {
                return HttpNotFound();
            }
            return View(arts_Crafts_R_S);
        }

        // POST: Arts_Crafts_R_S/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Arts_Crafts_R_S_ID,Category,Name,Price,Details")] Arts_Crafts_R_S arts_Crafts_R_S)
        {
            if (ModelState.IsValid)
            {
                db.Entry(arts_Crafts_R_S).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(arts_Crafts_R_S);
        }

        // GET: Arts_Crafts_R_S/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Arts_Crafts_R_S arts_Crafts_R_S = db.Arts_Crafts_R_S.Find(id);
            if (arts_Crafts_R_S == null)
            {
                return HttpNotFound();
            }
            return View(arts_Crafts_R_S);
        }

        // POST: Arts_Crafts_R_S/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Arts_Crafts_R_S arts_Crafts_R_S = db.Arts_Crafts_R_S.Find(id);
            db.Arts_Crafts_R_S.Remove(arts_Crafts_R_S);
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
