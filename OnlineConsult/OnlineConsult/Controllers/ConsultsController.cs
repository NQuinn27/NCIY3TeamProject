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
    public class ConsultsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Consults
        public ActionResult Index()
        {
            return View(db.Consultations.ToList());
        }

        //// GET: Consults/Details/5
        //public ActionResult Details(Guid? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Consult consult = db.Consultations.Find(id);
        //    if (consult == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(consult);
        //}

        //// GET: Consults/Create
        public ActionResult Create()
        {
            return View("Create");
        }

        // POST: Consults/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UID,PatientUID,DoctorUID,ScheduledTime,Notes")] Consult consult)
        {
            if (ModelState.IsValid)
            {
                consult.UID = Guid.NewGuid();
                db.Consultations.Add(consult);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(consult);
        }

        // GET: Consults/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Consult consult = db.Consultations.Find(id);
            if (consult == null)
            {
                return HttpNotFound();
            }
            return View(consult);
        }

        // POST: Consults/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UID,PatientUID,DoctorUID,ScheduledTime,Notes")] Consult consult)
        {
            if (ModelState.IsValid)
            {
                db.Entry(consult).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(consult);
        }

        // GET: Consults/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Consult consult = db.Consultations.Find(id);
            if (consult == null)
            {
                return HttpNotFound();
            }
            return View(consult);
        }

        // POST: Consults/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            Consult consult = db.Consultations.Find(id);
            db.Consultations.Remove(consult);
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
