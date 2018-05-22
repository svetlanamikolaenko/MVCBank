namespace MVCBank.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Role : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Managers", "Role", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Managers", "Role");
        }
    }
}
