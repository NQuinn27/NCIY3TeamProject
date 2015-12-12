using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineConsult.Models;
using Microsoft.AspNet.Identity;

namespace OnlineConsult.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
            var patient = GetCurrentPatient();
            if (patient != null)
            {
                return RedirectToAction("Home","Patients");
            }
            var doctor = GetCurrentDoctor();
            if (doctor != null)
            {
                return RedirectToAction("Index", "Doctors");
            }
            var user = getCurrentUser();
            if (user == null)
            {
                return View();
            }
            //if we are this far we know its an admin
            return RedirectToAction("Index", "Admin");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        private ApplicationUser getCurrentUser()
        {
            string currentUserId = User.Identity.GetUserId();
            if (currentUserId == null)
            {
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