namespace MVCBank.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddManagerId : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clients", "ManagerId", c => c.Int(nullable: false));
            CreateIndex("dbo.Clients", "ManagerId");
            AddForeignKey("dbo.Clients", "ManagerId", "dbo.Managers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clients", "ManagerId", "dbo.Managers");
            DropIndex("dbo.Clients", new[] { "ManagerId" });
            DropColumn("dbo.Clients", "ManagerId");
        }
    }
}
