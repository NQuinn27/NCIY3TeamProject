namespace OnlineConsult.MigApp
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Remove_appuserref : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Patients", "appUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Patients", new[] { "appUser_Id" });
            DropColumn("dbo.Patients", "appUser_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Patients", "appUser_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.Patients", "appUser_Id");
            AddForeignKey("dbo.Patients", "appUser_Id", "dbo.AspNetUsers", "Id");
        }
    }
}
