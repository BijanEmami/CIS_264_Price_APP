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
    public class Arts_Crafts_D_OController : Controller
    {
        private CIS_264_Price_APPContext db = new CIS_264_Price_APPContext();

        // GET: Arts_Crafts_D_O
        public ActionResult Index()
        {
            return View(db.Arts_Crafts_D_O.ToList());
        }

        // GET: Arts_Crafts_D_O/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Arts_Crafts_D_O arts_Crafts_D_O = db.Arts_Crafts_D_O.Find(id);
            if (arts_Crafts_D_O == null)
            {
                return HttpNotFound();
            }
            return View(arts_Crafts_D_O);
        }

        // GET: Arts_Crafts_D_O/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Arts_Crafts_D_O/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Arts_Crafts_D_O_ID,Category,Name,Price")] Arts_Crafts_D_O arts_Crafts_D_O)
        {
            if (ModelState.IsValid)
            {
                db.Arts_Crafts_D_O.Add(arts_Crafts_D_O);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(arts_Crafts_D_O);
        }

        // GET: Arts_Crafts_D_O/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Arts_Crafts_D_O arts_Crafts_D_O = db.Arts_Crafts_D_O.Find(id);
            if (arts_Crafts_D_O == null)
            {
                return HttpNotFound();
            }
            return View(arts_Crafts_D_O);
        }

        // POST: Arts_Crafts_D_O/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Arts_Crafts_D_O_ID,Category,Name,Price")] Arts_Crafts_D_O arts_Crafts_D_O)
        {
            if (ModelState.IsValid)
            {
                db.Entry(arts_Crafts_D_O).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(arts_Crafts_D_O);
        }

        // GET: Arts_Crafts_D_O/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Arts_Crafts_D_O arts_Crafts_D_O = db.Arts_Crafts_D_O.Find(id);
            if (arts_Crafts_D_O == null)
            {
                return HttpNotFound();
            }
            return View(arts_Crafts_D_O);
        }

        // POST: Arts_Crafts_D_O/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Arts_Crafts_D_O arts_Crafts_D_O = db.Arts_Crafts_D_O.Find(id);
            db.Arts_Crafts_D_O.Remove(arts_Crafts_D_O);
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
