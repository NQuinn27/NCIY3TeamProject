namespace OnlineConsult.MigDoctor
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<OnlineConsult.Models.DoctorDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"MigDoctor";
        }

        protected override void Seed(OnlineConsult.Models.DoctorDbContext context)
        {
            context.Doctors.AddOrUpdate(
                  p => p.ID,
                  new Doctor
                  {
                      firstName = "Thomas",
                      lastName = "Feighery",
                      signupDate = DateTime.Parse("1/1/2015"),
                      email = "name@domain.com",
                      qualifications = "M.D",
                  },
                  new Doctor
                  {
                      firstName = "Michael",
                      lastName = "Jones",
                      signupDate = DateTime.Parse("1/1/2015"),
                      email = "name@domain.com",
                      qualifications = "M.D",
                  },
                  new Doctor
                  {
                      firstName = "Anne",
                      lastName = "Bruton",
                      signupDate = DateTime.Parse("1/1/2015"),
                      email = "name@domain.com",
                      qualifications = "M.D",
                  }
                );
        }
    }
}
