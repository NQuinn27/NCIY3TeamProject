namespace OnlineConsult.MigApp
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_guid_id : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Consults");
            DropPrimaryKey("dbo.Patients");
            AddColumn("dbo.Consults", "UID", c => c.Guid(nullable: false));
            AddColumn("dbo.Consults", "PatientUID", c => c.Guid(nullable: false));
            AddColumn("dbo.Consults", "DoctorUID", c => c.Guid(nullable: false));
            AddColumn("dbo.Patients", "UID", c => c.Guid(nullable: false));
            AddPrimaryKey("dbo.Consults", "UID");
            AddPrimaryKey("dbo.Patients", "UID");
            DropColumn("dbo.Consults", "ID");
            DropColumn("dbo.Consults", "PatientID");
            DropColumn("dbo.Consults", "DoctorID");
            DropColumn("dbo.Patients", "ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Patients", "ID", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Consults", "DoctorID", c => c.Int(nullable: false));
            AddColumn("dbo.Consults", "PatientID", c => c.Int(nullable: false));
            AddColumn("dbo.Consults", "ID", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.Patients");
            DropPrimaryKey("dbo.Consults");
            DropColumn("dbo.Patients", "UID");
            DropColumn("dbo.Consults", "DoctorUID");
            DropColumn("dbo.Consults", "PatientUID");
            DropColumn("dbo.Consults", "UID");
            AddPrimaryKey("dbo.Patients", "ID");
            AddPrimaryKey("dbo.Consults", "ID");
        }
    }
}
