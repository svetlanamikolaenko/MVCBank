namespace MVCBank.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFullNameManager : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Managers", "FirstName", c => c.String(nullable: false, maxLength: 255));
            AddColumn("dbo.Managers", "LastName", c => c.String(nullable: false, maxLength: 255));
            DropColumn("dbo.Managers", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Managers", "Name", c => c.String(nullable: false, maxLength: 255));
            DropColumn("dbo.Managers", "LastName");
            DropColumn("dbo.Managers", "FirstName");
        }
    }
}
