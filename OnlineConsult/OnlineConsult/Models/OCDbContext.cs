using System.Data.Entity;

namespace OnlineConsult.Models
{
    public class OCDbContext : DbContext
    {
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        { 
        }
    }
}