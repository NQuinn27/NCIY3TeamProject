namespace OnlineConsult.MigApp
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class remove_testmodel : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.testModels", "name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.testModels", "name", c => c.String());
        }
    }
}
