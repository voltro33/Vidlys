namespace Vidly.Data
{
    public static class UserRoles
    {
        public const string Admin = "admin";
        public const string User = "user";
        public const string Employee = "employee";
    }
}


    /*
     
     using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vidly.Migrations
{
    /// <inheritdoc />
    public partial class seededUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [ProfileImageUrl], [Birthdate], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [GenreId]) VALUES (N'4141b965-69a5-4a0c-ba18-2e346f390da3', NULL, NULL, N'app-user', N'APP-USER', N'user@etickets.com', N'USER@ETICKETS.COM', 1, N'AQAAAAEAACcQAAAAEPFxDKKPVV9+6XuqeONKtZ8P0j+DnERdUKCEsGLA7gVLxBneoJSTjThuL+j0G5e6gQ==', N'ADIKYTBFLSXKFYBZBVUHTRKRIVIXVMWN', N'8fbfb3bd-94cd-4bd3-89a6-865801f1560b', NULL, 0, 0, NULL, 1, 0, NULL)
INSERT INTO [dbo].[AspNetUsers] ([Id], [ProfileImageUrl], [Birthdate], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [GenreId]) VALUES (N'ac3cff19-e283-4f99-8205-dc595b63ecb0', NULL, NULL, N'voltro33@gmail.com', N'VOLTRO33@GMAIL.COM', N'voltro33@gmail.com', N'VOLTRO33@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEMKNxsm19XzDxfl/i2nqazpgcdvVjDDUjtDcj4mWXSOka3uv+/fFq5OWIktuEUnmDA==', N'V2UUCABWVPWAUSLAJW64WCLNZMSNZ5QR', N'd956f218-e6f3-4cb5-9791-3c50406094a0', NULL, 0, 0, NULL, 1, 0, NULL)
INSERT INTO [dbo].[AspNetUsers] ([Id], [ProfileImageUrl], [Birthdate], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [GenreId]) VALUES (N'b286a646-f629-4b28-8aab-70fd4578bdca', NULL, NULL, N'employee-user', N'EMPLOYEE-USER', N'employee@example.com', N'EMPLOYEE@EXAMPLE.COM', 1, N'AQAAAAEAACcQAAAAEIZgh45EkEslBPWi+RZNb/Hhfq/K5428pZlSCPLuyHlrpMDisn26P7lVqPTxOraNSw==', N'CLU7DOVLQUY4OQNJUQ4HGQR3ZC7FISLU', N'eef1c142-1394-4071-b38d-52b57b3b948f', NULL, 0, 0, NULL, 1, 0, NULL)
INSERT INTO [dbo].[AspNetUsers] ([Id], [ProfileImageUrl], [Birthdate], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [GenreId]) VALUES (N'ef13b5dd-97b4-4868-8f49-ed078620c729', NULL, NULL, N'teddysmithdev', N'TEDDYSMITHDEV', N'teddysmithdeveloper@gmail.com', N'TEDDYSMITHDEVELOPER@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEFLRBUAMXR6AT4B9sGJRd3S8IqjZ/LNaIxDKI2hArk/k9aoOOxIdtQxkmz3ua9i8xQ==', N'GWJJNRHOSFC53FUU4NWYV3DXC4QUMVKU', N'c8ab20e5-67d5-479e-8a33-7f9f984d6b2a', NULL, 0, 0, NULL, 1, 0, NULL)

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'376d8e9c-8d21-4aac-b027-6d27cc232359', N'employee', N'EMPLOYEE', N'fe526677-5f5e-47db-aae7-ade39e2f1ae7')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'3953cfa3-678d-4b95-b2ed-cea936ad56c8', N'admin', N'ADMIN', N'40eb854c-e892-4c86-b225-b5beef931e43')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'7c76bd22-8bf5-49cc-82e8-7c70966140dd', N'user', N'USER', N'01d7c920-da20-4f10-a0a7-1d75826cd928')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'b286a646-f629-4b28-8aab-70fd4578bdca', N'376d8e9c-8d21-4aac-b027-6d27cc232359')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'ef13b5dd-97b4-4868-8f49-ed078620c729', N'3953cfa3-678d-4b95-b2ed-cea936ad56c8')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'4141b965-69a5-4a0c-ba18-2e346f390da3', N'7c76bd22-8bf5-49cc-82e8-7c70966140dd')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'ac3cff19-e283-4f99-8205-dc595b63ecb0', N'7c76bd22-8bf5-49cc-82e8-7c70966140dd')

");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}

     */
    