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
        public DateTime dateOfBirth { get; set; }
        public Gender sex { get; set; }
        public string email;

        //TODO
        //Array of Consults
        //Array of Ailments
        //

        public class PatientDbContext : DbContext
        {
            public DbSet<Patient> Patients { get; set; }
        }

    }
}