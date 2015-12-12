using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OnlineConsult.Models;

namespace OnlineConsult.Controllers
{
    public class ICD10Controller : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: ICD10
        public ActionResult Index()
        {
            return View(db.Ailments.ToList());
        }

        // GET: ICD10/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ICD10 iCD10 = db.Ailments.Find(id);
            if (iCD10 == null)
            {
                return HttpNotFound();
            }
            return View(iCD10);
        }

        // GET: ICD10/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ICD10/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,code,description,additional")] ICD10 iCD10)
        {
            if (ModelState.IsValid)
            {
                db.Ailments.Add(iCD10);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(iCD10);
        }

        // GET: ICD10/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ICD10 iCD10 = db.Ailments.Find(id);
            if (iCD10 == null)
            {
                return HttpNotFound();
            }
            return View(iCD10);
        }

        // POST: ICD10/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,code,description,additional")] ICD10 iCD10)
        {
            if (ModelState.IsValid)
            {
                db.Entry(iCD10).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(iCD10);
        }

        // GET: ICD10/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ICD10 iCD10 = db.Ailments.Find(id);
            if (iCD10 == null)
            {
                return HttpNotFound();
            }
            return View(iCD10);
        }

        // POST: ICD10/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ICD10 iCD10 = db.Ailments.Find(id);
            db.Ailments.Remove(iCD10);
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
