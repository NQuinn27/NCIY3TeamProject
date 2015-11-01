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
        public DateTime ScheduledTime { get; set; }
        public String Notes { get; set; }

        public Consult()
        {
            this.UID = Guid.NewGuid();
        }
    }
}