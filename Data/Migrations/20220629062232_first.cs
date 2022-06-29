using Microsoft.EntityFrameworkCore.Migrations;

namespace WebFPTBook.Data.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "558556a8-2c9a-40d7-bd7b-918942f4a763");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d254d4fd-6418-486d-80a3-7b2c51a80d97");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "1b24e895-5e3e-4279-be5f-e1145aca890d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "58de3b1d-b58f-48c2-8686-796e3da29a01");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "d8a2241f-ee2d-4b47-a57d-7c13be61570b");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "Image", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Roles", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "42e415fd-5420-470c-b5e3-0f6b86d28fb0", 0, "a6d9e9fb-8ab6-47d7-918c-c48f80566dcd", "admin@gmail.com", false, "", false, null, "Admin", null, null, null, "0123456789", false, "Admin", "4c9d199a-f748-4b47-9c46-7c3d2c5ba3ab", false, null },
                    { "c8c9de27-7dfc-442a-af1d-a1a53e40005b", 0, "4cd45379-9dd4-425d-84eb-6e66d18dd2bd", "customer@gmail.com", false, "", false, null, "Customer", null, null, null, "0987654321", false, "Customer", "67ee9dec-e275-49d9-b94c-05b8a8154d56", false, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "42e415fd-5420-470c-b5e3-0f6b86d28fb0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c8c9de27-7dfc-442a-af1d-a1a53e40005b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "85b277c2-401b-446b-9618-7b85088723cd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "32774bc7-dab9-4521-ab9d-6c2664428a60");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "5a6ce9ee-0c0d-43d6-84cb-68d1911410c7");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "Image", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Roles", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "d254d4fd-6418-486d-80a3-7b2c51a80d97", 0, "fc198e08-6ae1-4c1b-ba28-71f91f5b7847", "admin@gmail.com", false, "", false, null, "Admin", null, null, null, "0123456789", false, "Admin", "4bb61b5f-62ba-4435-9493-b9d5a71199fa", false, null },
                    { "558556a8-2c9a-40d7-bd7b-918942f4a763", 0, "9407eff9-e750-424d-9f47-34f00cb6b691", "customer@gmail.com", false, "", false, null, "Customer", null, null, null, "0987654321", false, "Customer", "256ab0d7-4546-498a-a996-4c12e33ff3f3", false, null }
                });
        }
    }
}
