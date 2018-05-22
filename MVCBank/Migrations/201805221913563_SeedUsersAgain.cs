namespace MVCBank.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsersAgain : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'71f704f9-240f-4665-a972-d4c0588a1c8b', N'guest@mvcbank.com', 0, N'AHA5qa6mEW+hR1xxOTxalxbFZ6+EwgmJT2V1GYiaTUuUCkxB036icXIavvwchD9ILQ==', N'86bc3c6c-8ae7-4bcb-bad3-3be596037e9e', NULL, 0, 0, NULL, 1, 0, N'guest@mvcbank.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'e867b004-14a1-4e28-acbf-2607497eb7c3', N'admin@mvcbank.com', 0, N'ADtnia2Y7rwwOEkP34tLFQ7dDSaGFNEX0N+KTBUsVDe6H5aU3RcXwLk2XzTuvy8atQ==', N'737aca0b-ac77-4523-a447-f9214ddbd26a', NULL, 0, 0, NULL, 1, 0, N'admin@mvcbank.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'1f9f7e24-d885-4c5a-b2ba-09f037a6676a', N'CanManageUsers')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'e867b004-14a1-4e28-acbf-2607497eb7c3', N'1f9f7e24-d885-4c5a-b2ba-09f037a6676a')

");
        }
        
        public override void Down()
        {
        }
    }
}
