using System;
using OnlineConsult.Enums;
using System.Data.Entity;
namespace OnlineConsult.Models
{
    public class Doctor
    {
        public int ID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public DateTime signupDate { get; set; }
        public string qualifications { get; set; }

        public class DoctorDBContext : DbContext
        {
            public DbSet<Doctor> Doctors { get; set; }
        }
    }
}