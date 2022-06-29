using Microsoft.EntityFrameworkCore.Migrations;

namespace WebFPTBook.Data.Migrations
{
    public partial class newidentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "54671688-6aa8-4073-badb-08cd2fe2c3df");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "57fd2d30-025b-443d-a345-2b82aac27472");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "84cf12aa-7d6c-44c1-b77b-544123dc4cff");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "d1f8ba0d-a5bd-4454-b3af-4baa42faebb2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "eb1957c1-0f64-4f2e-8b10-2c7458dd7d55");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "Image", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Roles", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "129b92f1-0e16-4867-b030-84611cde320a", 0, "bb348b0c-5941-4bf5-a173-8e008b709185", "admin@gmail.com", false, "", false, null, "Admin", null, null, null, "0123456789", false, "Admin", "aa2c9c1e-74a3-474d-a624-454c7a155d38", false, null },
                    { "99198e2c-6393-4e2d-80cf-6ab950eb3278", 0, "58e6838d-5d20-458f-a41a-5012bba2e270", "customer@gmail.com", false, "", false, null, "Customer", null, null, null, "0987654321", false, "Customer", "d0deef4e-4abd-45b2-9a7c-6628ccb40c9f", false, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "129b92f1-0e16-4867-b030-84611cde320a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99198e2c-6393-4e2d-80cf-6ab950eb3278");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "1fd3c5d4-60fa-49b0-9420-2557699d7a23");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "af223d30-9e6a-4a79-bc34-3d9b5e897aa2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "6add2aeb-e798-4c43-802c-b866bd0fb49d");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "Image", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Roles", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "54671688-6aa8-4073-badb-08cd2fe2c3df", 0, "807e086b-3bbb-421a-a8e7-e7ce345ac059", "admin@gmail.com", false, "", false, null, "Admin", null, null, null, "0123456789", false, "Admin", "d7418c60-1c46-4bd3-9cdc-2ad123da6f18", false, null },
                    { "57fd2d30-025b-443d-a345-2b82aac27472", 0, "581fbfb1-126a-4706-a4e7-c6d51078eb71", "customer@gmail.com", false, "", false, null, "Customer", null, null, null, "0987654321", false, "Customer", "71cb9ef7-cd44-4df6-867c-b4b551602e8f", false, null }
                });
        }
    }
}
