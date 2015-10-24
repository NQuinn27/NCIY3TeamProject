namespace OnlineConsult.MigPatient
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<OnlineConsult.Models.PatientDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"MigPatient";
        }

        protected override void Seed(OnlineConsult.Models.PatientDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
                context.Patients.AddOrUpdate(
                  p => p.ID,
                  new Patient {
                      firstName = "Andrew",
                      lastName = "Peters",
                      gender = Enums.Gender.Male,
                      dateOfBirth = DateTime.Parse("1/1/1970"),
                      signupDate = DateTime.Parse("1/1/2015"),
                      email = "name@domain.com",
                  },
                  new Patient
                  {
                      firstName = "Joe",
                      lastName = "Bloggs",
                      gender = Enums.Gender.Male,
                      dateOfBirth = DateTime.Parse("1/1/1970"),
                      signupDate = DateTime.Parse("1/1/2015"),
                      email = "name@domain.com",
                  },
                  new Patient
                  {
                      firstName = "Jane",
                      lastName = "Bloggs",
                      gender = Enums.Gender.Male,
                      dateOfBirth = DateTime.Parse("1/1/1970"),
                      signupDate = DateTime.Parse("1/1/2015"),
                      email = "name@domain.com",
                  }
                );
            //
        }
    }
}
