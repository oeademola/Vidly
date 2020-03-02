namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'5ca87254-1a5b-4bff-8bdf-41d0cdf3539c', N'guest@vidrent.com', 0, N'AHLL2dP4jetGkgbWQiNXq5HnajlWXLkthdkVaShwsRBHmgymSqeh/z60opoYjOlVRg==', N'f6281794-4b30-4053-9015-83620b668ac3', NULL, 0, 0, NULL, 1, 0, N'guest@vidrent.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'aba67396-ce41-4829-879c-443a908c9e41', N'admin@vidrent.com', 0, N'AB5LLqMuCQlYZMaMx2ZHCyFmQvk0QNeCE5A13LQzXnUHXYdVoMVPIbmW0P5dC2A7Fg==', N'68b4daf8-6d76-47b5-a11e-d5933fe51deb', NULL, 0, 0, NULL, 1, 0, N'admin@vidrent.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'ed27b0c2-d38b-47dc-a74e-dd424551c9fe', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'aba67396-ce41-4829-879c-443a908c9e41', N'ed27b0c2-d38b-47dc-a74e-dd424551c9fe')

");
        }
        
        public override void Down()
        {
        }
    }
}
