namespace OnlineConsult.MigApp
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_message_param_text : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Messages", "text", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Messages", "text");
        }
    }
}
