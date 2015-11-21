using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OnlineConsult.Models;
using Microsoft.AspNet.Identity.Owin;
using System.Data.Entity.Validation;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;

namespace OnlineConsult.Controllers
{
    public class PatientsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        private ApplicationSignInManager _signInManager;
        private ApplicationUserManager _userManager;
        private PatientRegisterViewModel _registerViewModel;
        private LoginViewModel _loginViewModel;

        public PatientsController()
        {
        }

        public PatientsController(ApplicationUserManager userManager, ApplicationSignInManager signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public ApplicationSignInManager SignInManager
        {
            get
            {
                return _signInManager ?? HttpContext.GetOwinContext().Get<ApplicationSignInManager>();
            }
            private set
            {
                _signInManager = value;
            }
        }

        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }

        // GET: Patients
        public ActionResult Index()
        {
            ViewData["registerModel"] = _registerViewModel;
            ViewData["loginViewModel"] = _loginViewModel;

            var patient = GetCurrentPatient();
            if (patient != null) {
                return RedirectToAction("Home");
            }

            return View();
            
        }

        public ActionResult List()
        {
            ViewData["Count"] = db.Patients.ToList().Count;
            return View(db.Patients.ToList());
        }

        // GET: Patients/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Patient patient = db.Patients.Find(id);
            if (patient == null)
            {
                return HttpNotFound();
            }
            return View(patient);
        }

        // GET: Patients/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Patients/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,firstName,lastName,email,dateOfBirth,signupDate,gender")] Patient patient)
        {
            if (ModelState.IsValid)
            {
                db.Patients.Add(patient);
                db.SaveChanges();
                return RedirectToAction("List");
            }

            return View(patient);
        }

        // GET: Patients/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Patient patient = db.Patients.Find(id);
            if (patient == null)
            {
                return HttpNotFound();
            }
            return View(patient);
        }

        // POST: Patients/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,firstName,lastName,email,dateOfBirth,signupDate,gender")] Patient patient)
        {
            if (ModelState.IsValid)
            {
                db.Entry(patient).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("List");
            }
            return View(patient);
        }

        // GET: Patients/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Patient patient = db.Patients.Find(id);
            if (patient == null)
            {
                return HttpNotFound();
            }
            return View(patient);
        }

        // POST: Patients/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            Patient patient = db.Patients.Find(id);
            db.Patients.Remove(patient);
            db.SaveChanges();
            return RedirectToAction("List");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        //GET Patients/Home
        public ActionResult Home()
        {
            bool val1 = System.Web.HttpContext.Current.User.Identity.IsAuthenticated;
            if (val1 == false)
            {
                RedirectToLocal("Patients");
            }

            var patient = GetCurrentPatient();

            var consulatations = db.Consultations
                .Where(c => c.PatientUID == patient.UID)
                .OrderBy(c => c.ScheduledTime); ;

            ViewData["Patient"] = patient;
            ViewData["Consultations"] = consulatations;
            return View();

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

        //POST: Patients/Login
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await SignInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, shouldLockout: false);
                switch (result)
                {
                    case SignInStatus.Success:
                        //Find a Patient to back it up
                        var patient= db.Patients
                                    .Where(b => b.email == model.Email)
                                    .FirstOrDefault();
                        if (patient == null) {
                            //No patient backin this login
                            ViewBag["Error"] = "No Patient Found";
                            return View();
                        }

                        return RedirectToLocal("/Patients/Home");
                    case SignInStatus.LockedOut:
                        return View("Lockout");
                    case SignInStatus.RequiresVerification:
                        return RedirectToAction("SendCode", new { ReturnUrl = "/Patients/Home", RememberMe = model.RememberMe });
                    case SignInStatus.Failure:
                    default:
                        ModelState.AddModelError("", "Invalid login attempt.");
                        return View(model);
                }
            }
            return View(model);
        }
        // POST: /Patients/Register
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Register(PatientRegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var appUser = new ApplicationUser { UserName = model.Email, Email = model.Email };
                var result = await UserManager.CreateAsync(appUser, model.Password);
                if (result.Succeeded)
                {
                    await SignInManager.SignInAsync(appUser, isPersistent: false, rememberBrowser: false);

                    //Now we have an app user created, we can continue to create the Patient
                    var patient = new Patient(model.FirstName, model.LastName, model.Email, model.DateOfBirth, model.Gender);
                    if (patient != null)
                    {
                        try
                        {
                            // Your code...
                            // Could also be before try if you know the exception occurs in SaveChanges
                            db.Patients.Add(patient);
                            db.SaveChanges();
                        }
                        catch (DbEntityValidationException e)
                        {
                            foreach (var eve in e.EntityValidationErrors)
                            {
                                Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                                    eve.Entry.Entity.GetType().Name, eve.Entry.State);
                                foreach (var ve in eve.ValidationErrors)
                                {
                                    Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                                        ve.PropertyName, ve.ErrorMessage);
                                }
                            }
                            throw;
                        }
                    }
                    return RedirectToAction("Home");
                }

                ViewData["Errors"] = result.Errors;
                return View("index");
            }
            // If we got this far, something failed, redisplay form
            return View("index");
        }

        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            return RedirectToAction("Index", "Home");
        }
    }
}
