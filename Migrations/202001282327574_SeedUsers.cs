namespace VidlyV2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'67ce64f2-5392-4b37-af8b-aeb5da45bfbe', N'guest@vidly.com', 0, N'AHSIYFU54YqlFb45rArI9sujku7qXluSAb+WTVB4dV8k7JNrM9aGKxanMsg73A8y7Q==', N'721fe75b-071c-4771-9eb2-bc535d5e9116', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'b42cfcee-d4ab-4c51-b2b4-d5fe041d390b', N'admin@vidly.com', 0, N'APf+9KKRY2jbD/pGfWXIKOyHbtNUATT6wME0ZX3CHx0vUiiRA7kkjBfZLCKTdWdiPQ==', N'95fa6531-562d-4c66-9bec-b27bea4f9748', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'cd589be7-0e81-4b30-b783-28c475d9427b', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'b42cfcee-d4ab-4c51-b2b4-d5fe041d390b', N'cd589be7-0e81-4b30-b783-28c475d9427b')
");
        }
        
        public override void Down()
        {
        }
    }
}
