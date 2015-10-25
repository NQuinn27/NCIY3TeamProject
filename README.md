# NCIY3TeamProject
Team project and databases project for Year 3 BSHCE at NCI

### Contribution
Perform all changes on a branch, and file a pull request when finished. Keep the branches to one or two items to ensure a painless merge.

### Setting up your environment
This project uses Visual Studio 2015 and [SQL LocalDB 2012](https://www.microsoft.com/en-ie/download/details.aspx?id=29062). Use both of these versions to avoid headaches.

#### Create database
When SQL LocalDB 2012 is installed, navigate in command prompt to "Program Files\Microsoft SQL Server\110\LocalDB\Instances" (you may need to create the instances folder).
Run

    sqllocaldb create "v11.0"

#### Run the seed migration
Build the project, ensure no errors. At this point you should be able to navigate to the /patients or /doctors uris and see empty lists. This means database is connected but empty.

Open the package console (Tools > NuGet Package Manager > Package Manager Console). Run the following command in the package manager:

    update-database -configuration OnlineConsult.Migrations.Configuration

After a successful seed you should have some data in the database for Doctors and Patients. Anyone can add to this data in the Migrations\Configuration.cs file.

#### Changing the models
Any change in the model must be followed by a migration. Name the migration according to what attributes were added. In package manager console run:

    Add-Migration -configuration OnlineConsult.Migrations.Configuration MIGRATION_NAME

Then,

    update-database -configuration OnlineConsult.Migrations.Configuration
