namespace OnlineConsult.MigApp
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_app_roles : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "AppRole_ID", c => c.Int());
            CreateIndex("dbo.AspNetUsers", "AppRole_ID");
            AddForeignKey("dbo.AspNetUsers", "AppRole_ID", "dbo.Roles", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUsers", "AppRole_ID", "dbo.Roles");
            DropIndex("dbo.AspNetUsers", new[] { "AppRole_ID" });
            DropColumn("dbo.AspNetUsers", "AppRole_ID");
        }
    }
}
