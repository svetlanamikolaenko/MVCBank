namespace MVCBank.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRoleId : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Managers", "RoleId", c => c.Int(nullable: false));
            CreateIndex("dbo.Managers", "RoleId");
            AddForeignKey("dbo.Managers", "RoleId", "dbo.Roles", "Id", cascadeDelete: true);
            DropColumn("dbo.Managers", "Role");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Managers", "Role", c => c.String());
            DropForeignKey("dbo.Managers", "RoleId", "dbo.Roles");
            DropIndex("dbo.Managers", new[] { "RoleId" });
            DropColumn("dbo.Managers", "RoleId");
            DropTable("dbo.Roles");
        }
    }
}
