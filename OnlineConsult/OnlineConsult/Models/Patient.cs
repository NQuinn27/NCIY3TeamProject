using System;
using OnlineConsult.Enums;
using System.Data.Entity;

namespace OnlineConsult.Models
{
    public class Patient
    {

        public int ID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public DateTime dateOfBirth { get; set; }
        public DateTime signupDate { get; set; }
        public Gender gender { get; set; }

        public class PatientDBContext : DbContext
        {
            public DbSet<Patient> Patients { get; set; }
        }

    }
}