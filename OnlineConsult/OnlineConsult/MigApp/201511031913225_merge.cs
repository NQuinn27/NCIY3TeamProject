namespace OnlineConsult.MigApp
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class merge : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Doctors");
            AddColumn("dbo.Doctors", "UID", c => c.Guid(nullable: false));
            AddPrimaryKey("dbo.Doctors", "UID");
            DropColumn("dbo.Doctors", "ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Doctors", "ID", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.Doctors");
            DropColumn("dbo.Doctors", "UID");
            AddPrimaryKey("dbo.Doctors", "ID");
        }
    }
}
