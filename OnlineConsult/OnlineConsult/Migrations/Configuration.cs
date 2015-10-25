namespace OnlineConsult.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<OnlineConsult.Models.OCDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "OnlineConsult.Models.OCDbContext";
        }

        protected override void Seed(OnlineConsult.Models.OCDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
                context.Patients.AddOrUpdate(
                  p => p.firstName,
                  new Patient {
                      firstName = "Andrew",
                      lastName = "Peters",
                      dateOfBirth = DateTime.Parse("1/1/1970"),
                      signupDate = DateTime.Parse("1/1/2015"),
                      gender = Enums.Gender.Male,
                      email = "name@domain.com"
                  },
                  new Patient {
                      firstName = "Brice",
                      lastName = "Lambson",
                      dateOfBirth = DateTime.Parse("1/1/1970"),
                      signupDate = DateTime.Parse("1/1/2015"),
                      gender = Enums.Gender.Male,
                      email = "name@domain.com"
                  },
                  new Patient {
                      firstName = "Rowan",
                      lastName = "Miller",
                      dateOfBirth = DateTime.Parse("1/1/1970"),
                      signupDate = DateTime.Parse("1/1/2015"),
                      gender = Enums.Gender.Male,
                      email = "name@domain.com"
                  }
                );

            context.Doctors.AddOrUpdate(
                p => p.firstName,
                new Doctor {
                    firstName = "Michael",
                    lastName = "Molloy",
                    qualifications = "M.D",
                    signupDate = DateTime.Parse("1/1/2015"),
                    email = "name@domain.com"
                },

                new Doctor
                {
                    firstName = "Thomas",
                    lastName = "Feighery",
                    qualifications = "M.D",
                    signupDate = DateTime.Parse("1/1/2015"),
                    email = "name@domain.com"
                },

                new Doctor
                {
                    firstName = "Ann",
                    lastName = "Bruton",
                    qualifications = "M.D",
                    signupDate = DateTime.Parse("1/1/2015"),
                    email = "name@domain.com"
                }
                );
            
        }
    }
}
