namespace OnlineConsult.MigApp
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addAll : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Doctors",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        firstName = c.String(),
                        lastName = c.String(),
                        email = c.String(),
                        signupDate = c.DateTime(nullable: false),
                        qualifications = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        applicationUserId = c.Int(nullable: false, identity: true),
                        ID = c.Int(nullable: false),
                        firstName = c.String(),
                        lastName = c.String(),
                        email = c.String(),
                        dateOfBirth = c.DateTime(nullable: false),
                        signupDate = c.DateTime(nullable: false),
                        gender = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.applicationUserId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Patients");
            DropTable("dbo.Doctors");
        }
    }
}
