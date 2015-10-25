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
    public class testModelsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: testModels
        public ActionResult Index()
        {
            return View(db.tests.ToList());
        }

        // GET: testModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            testModel testModel = db.tests.Find(id);
            if (testModel == null)
            {
                return HttpNotFound();
            }
            return View(testModel);
        }

        // GET: testModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: testModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,name")] testModel testModel)
        {
            if (ModelState.IsValid)
            {
                db.tests.Add(testModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(testModel);
        }

        // GET: testModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            testModel testModel = db.tests.Find(id);
            if (testModel == null)
            {
                return HttpNotFound();
            }
            return View(testModel);
        }

        // POST: testModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,name")] testModel testModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(testModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(testModel);
        }

        // GET: testModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            testModel testModel = db.tests.Find(id);
            if (testModel == null)
            {
                return HttpNotFound();
            }
            return View(testModel);
        }

        // POST: testModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            testModel testModel = db.tests.Find(id);
            db.tests.Remove(testModel);
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
