using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OnlineConsult.Models;
using Microsoft.AspNet.Identity;

namespace OnlineConsult.Controllers
{
    public class ConsultsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Consults
        public ActionResult Index()
        {
            var patient = GetCurrentPatient();
            if (patient != null)
            {
                return RedirectToAction("Home", "Patients");
            }
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

        public ActionResult Book()
        {
            return View("Create");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Book([Bind(Include = "UID,PatientUID,DoctorUID,ScheduledTime,Notes")] Consult consult)
        {
            if (ModelState.IsValid)
            {
                var DoctorUID = Request["listbox"];
                consult.DoctorUID = new Guid(DoctorUID);

                var patient = GetCurrentPatient();
                consult.PatientUID = patient.UID;

                consult.UID = Guid.NewGuid();
                db.Consultations.Add(consult);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(consult);
        }

        private Patient GetCurrentPatient()
        {
            string currentUserId = User.Identity.GetUserId();
            ApplicationUser currentUser = db.Users.FirstOrDefault(x => x.Id == currentUserId);
            if (currentUser == null)
            {
                return null;
            }
            string email = currentUser.Email;
            Patient patient = db.Patients.FirstOrDefault(p => p.email == email);
            return patient;
        }

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
                var DoctorUID = Request["listbox"];
                consult.DoctorUID = new Guid(DoctorUID);

                var patient = GetCurrentPatient();
                consult.PatientUID = patient.UID;

                consult.UID = Guid.NewGuid();
                db.Consultations.Add(consult);
                db.SaveChanges();
                return RedirectToAction("Home", "Patients");
            }

            return View(consult);
        }

        public ActionResult Initiate(string ident)
        {
            string id = Request.Params["id"];
            if (id == null)
            {
                if (ident == null)
                {
                    return RedirectToAction("Home", "Patients");
                }
                id = ident;
            }
            Guid consultID = new Guid(id);
            Consult c = db.Consultations.Find(consultID);
            ViewData["consult"] = c;
            var doctor = db.Doctors.Find(c.DoctorUID);
            ViewData["doctor"] = db.Doctors.Find(c.DoctorUID);
            var patient = GetCurrentPatient();
            ViewData["patient_id"] = patient.UID;
            ViewData["doctor_id"] = doctor.UID;
            var sent_messages = db.Messages.Where(m => m.senderID == patient.UID)
                .Where(m => m.recieverID == doctor.UID)
                .Where(m => m.consultId == c.UID)
                .OrderBy(m => m.sentAt);
            var recieved_messages = db.Messages.Where(m => m.senderID == doctor.UID)
                .Where(m => m.recieverID == patient.UID)
                .Where(m => m.consultId == c.UID)
                .OrderBy(m => m.sentAt);
            var all_messages = sent_messages.Concat(recieved_messages).ToArray();
            var sorted = all_messages.OrderBy(m => m.sentAt).ToList();
            ViewData["messages"] = sorted;
            ViewData["consult_id"] = c.UID;
            return View();
        }

        [HttpPost]
        public ActionResult CreateMessage(string message, Guid consultId, Guid doctorId, Guid patientId)
        {
            var newMessage = new Message();
            newMessage.text = message;
            newMessage.consultId = consultId;
            newMessage.senderID = patientId;
            newMessage.recieverID = doctorId;
            newMessage.sentAt = DateTime.Now;
            db.Messages.Add(newMessage);

            var response = new Message();
            response.text = "a quick response";
            response.consultId = consultId;
            response.senderID = doctorId;
            response.recieverID = patientId;
            response.sentAt = DateTime.Now;
            db.Messages.Add(response);
            db.SaveChanges();
            return Redirect($"/Consults/Initiate?id={consultId}");
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
