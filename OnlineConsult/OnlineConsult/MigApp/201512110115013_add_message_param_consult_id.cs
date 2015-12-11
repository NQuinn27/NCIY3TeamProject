namespace OnlineConsult.MigApp
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_message_param_consult_id : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Messages", "consultId", c => c.Guid(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Messages", "consultId");
        }
    }
}
