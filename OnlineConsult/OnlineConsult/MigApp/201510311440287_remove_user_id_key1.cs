namespace OnlineConsult.MigApp
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class remove_user_id_key1 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Patients");
            AlterColumn("dbo.Patients", "email", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Patients", "email");
            DropColumn("dbo.Patients", "ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Patients", "ID", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.Patients");
            AlterColumn("dbo.Patients", "email", c => c.String());
            AddPrimaryKey("dbo.Patients", "ID");
        }
    }
}
