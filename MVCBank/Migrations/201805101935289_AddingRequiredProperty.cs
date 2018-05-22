namespace MVCBank.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingRequiredProperty : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clients", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Managers", "Name", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Managers", "Name", c => c.String());
            AlterColumn("dbo.Clients", "Name", c => c.String());
        }
    }
}
