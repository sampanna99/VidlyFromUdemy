namespace Vidlly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'36cf5ec4-08bc-487b-9d00-5eba0ec2bdd4', N'admin@vidly.com', 0, N'AAeQ5k6iSdNKnpPX8NGQLuH7hsMnRSnRdDzl+FPvDXuMDecSYY8hTpZRZAtd+0DkvA==', N'1878ecff-fbfe-4534-91bd-1f5cab234251', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'416b0adc-6d19-4c37-9dff-e770931d74dd', N'guest@vidly.com', 0, N'AF8RWAiUwTyPXXV/5I1fyFrSH16q7PHVfpAiwMYRV6ZHGNmzG3MuUSB73wC3JnKq5Q==', N'2e719a2f-120a-4487-b20a-753a8c763ca7', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'ef3835a1-0cf4-40ef-903d-60bb58402001', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'36cf5ec4-08bc-487b-9d00-5eba0ec2bdd4', N'ef3835a1-0cf4-40ef-903d-60bb58402001')


");
        }
        
        public override void Down()
        {
        }
    }
}
