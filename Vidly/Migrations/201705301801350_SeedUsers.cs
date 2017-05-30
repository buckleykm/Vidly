namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'41e8ef5e-6d32-42b1-b6b2-6f447afa8612', N'guest@vidly.com', 0, N'AIMImTykOlbeHZ+lXFuRStpcCcUxs44mmzG7yUESZ1wr/z8NmGMAjjetC6QGwaV8YQ==', N'9f078552-dba8-4557-bb4b-1271cf3062b0', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'559fef3c-8d11-4610-80e3-9ceea64bae3f', N'admin@vidly.com', 0, N'AH9tl1NGV1100eg2JwcCgFgC5QwP8LuuVPsg07bE82ouIkuPagNjZ1qu/CgL3t7BAA==', N'53c17fe0-1033-4fd8-bd18-8427ae8bca83', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'50bf07b5-be11-4bc3-b57f-7d3572680b8d', N'CanManageMovies')


INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'559fef3c-8d11-4610-80e3-9ceea64bae3f', N'50bf07b5-be11-4bc3-b57f-7d3572680b8d')


");
        }
        
        public override void Down()
        {
        }
    }
}
