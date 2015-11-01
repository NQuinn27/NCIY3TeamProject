namespace OnlineConsult.MigApp
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_appuser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Patients", "appUser_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.Patients", "appUser_Id");
            AddForeignKey("dbo.Patients", "appUser_Id", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Patients", "appUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Patients", new[] { "appUser_Id" });
            DropColumn("dbo.Patients", "appUser_Id");
        }
    }
}
