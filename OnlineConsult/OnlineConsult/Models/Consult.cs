using System;
using System.ComponentModel.DataAnnotations;

namespace OnlineConsult.Models
{
    public class Consult
    {
        [Key]
        public Guid UID { get; set; }
        public Guid PatientUID { get; set; }
        public Guid DoctorUID { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ScheduledTime { get; set; }

        public String Notes { get; set; }

        public Consult()
        {
            this.UID = Guid.NewGuid();
        }

        public string DoctorName()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            Doctor d = db.Doctors.Find(DoctorUID);
            if (d != null)
            {
                String s = String.Format("{0} {1}", d.firstName, d.lastName);
                return s;
            }
            return String.Format("{0}",DoctorUID);
        }

        public string PatientName()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            Patient d = db.Patients.Find(PatientUID);
            if (d != null)
            {
                String s = String.Format("{0} {1}", d.firstName, d.lastName);
                return s;
            }
            return String.Format("{0}", PatientUID);
        }
    }
}