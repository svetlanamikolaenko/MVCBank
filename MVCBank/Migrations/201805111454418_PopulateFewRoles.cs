namespace MVCBank.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateFewRoles : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Roles ON");
            Sql("INSERT INTO Roles(Id, Name) VALUES (1, 'Admin')");
            Sql("INSERT INTO Roles(Id, Name) VALUES (2, 'User')");
            Sql("SET IDENTITY_INSERT Roles OFF");
        }
        
        public override void Down()
        {
        }
    }
}
