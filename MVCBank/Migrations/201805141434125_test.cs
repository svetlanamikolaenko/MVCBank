namespace MVCBank.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Managers", "FirstName", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Managers", "LastName", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Managers", "LastName", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Managers", "FirstName", c => c.String(nullable: false, maxLength: 255));
        }
    }
}
