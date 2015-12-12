using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineConsult.Models;
using Microsoft.AspNet.Identity;

namespace OnlineConsult.Controllers
{
    public class AdminController : Controller
    {

        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Admin
        public ActionResult Index()
        {

            var user = getCurrentUser();
            if (user == null || GetCurrentDoctor()!=null || GetCurrentPatient()!=null)
            {
                return View("Unauthorized");
            }
            return View();
        }

        public ActionResult Patients()
        {
            ViewData["Count"] = db.Patients.ToList().Count;
            return View(db.Patients.ToList());
        }
        public PartialViewResult SearchPatients(string keyword)
        {
            // System.Threading.Thread.Sleep(2000);
            var codes = db.Patients.Where(f => f.firstName.Contains(keyword)).ToList();
            var descriptions = db.Patients.Where(f => f.lastName.Contains(keyword)).ToList();
            var additionals = db.Patients.Where(f => f.email.Contains(keyword)).ToList();
            var merge = codes.Concat(descriptions).Concat(additionals);
            var sortedList = merge.OrderBy(d => d.firstName);
            return PartialView(sortedList);
        }


        public ActionResult ICD10()
        {
            ViewData["Count"] = db.Ailments.ToList().Count;
            return View(db.Ailments.ToList());
        }

        public PartialViewResult SearchAilments(string keyword)
        {
            // System.Threading.Thread.Sleep(2000);
            var codes = db.Ailments.Where(f => f.code.Contains(keyword)).ToList();
            var descriptions = db.Ailments.Where(f => f.description.Contains(keyword)).ToList();
            var additionals = db.Ailments.Where(f => f.additional.Contains(keyword)).ToList();
            var merge = codes.Concat(descriptions).Concat(additionals);
            var sortedList = merge.OrderBy(d => d.code);
            return PartialView(sortedList);
        }

        public ActionResult Doctors()
        {
            ViewData["Count"] = db.Doctors.ToList().Count;
            return View(db.Doctors.ToList());
        }

        public PartialViewResult SearchDoctors(string keyword)
        {
            // System.Threading.Thread.Sleep(2000);
            var codes = db.Doctors.Where(f => f.firstName.Contains(keyword)).ToList();
            var descriptions = db.Doctors.Where(f => f.lastName.Contains(keyword)).ToList();
            var additionals = db.Doctors.Where(f => f.email.Contains(keyword)).ToList();
            var merge = codes.Concat(descriptions).Concat(additionals);
            var sortedList = merge.OrderBy(d => d.firstName);
            return PartialView(sortedList);
        }


        private ApplicationUser getCurrentUser()
        {
            string currentUserId = User.Identity.GetUserId();
            if (currentUserId == null) {
                return null;
            }
            ApplicationUser appUser = db.Users.FirstOrDefault(u => u.Id == currentUserId);
            return appUser;
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

        private Doctor GetCurrentDoctor()
        {
            string currentUserId = User.Identity.GetUserId();
            ApplicationUser currentUser = db.Users.FirstOrDefault(x => x.Id == currentUserId);
            if (currentUser == null)
            {
                return null;
            }
            string email = currentUser.Email;
            Doctor doctor = db.Doctors.FirstOrDefault(p => p.email == email);
            return doctor;
        }


    }

}