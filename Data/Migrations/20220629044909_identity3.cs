using Microsoft.EntityFrameworkCore.Migrations;

namespace WebFPTBook.Data.Migrations
{
    public partial class identity3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5350203b-275a-4579-8362-8abd1dba9843");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "626cb462-4394-4aea-8df2-f3e76da4a785");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                value: "33e9c2df-ee33-478a-8e9f-690c7a8125fb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "3f9302d2-b04d-4207-93ea-f5826fe3ccf9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "c3ce6911-8f68-417f-9247-e9d52a021aeb");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "Image", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Roles", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "626cb462-4394-4aea-8df2-f3e76da4a785", 0, "346befc3-4657-4128-9e21-4131dc7fa9a6", "admin@gmail.com", false, "", false, null, "Admin", null, null, null, "0123456789", false, "Admin", "107de7e5-9f99-4dfd-962a-e87896342253", false, null },
                    { "5350203b-275a-4579-8362-8abd1dba9843", 0, "ca15a2b6-02a8-4701-92c6-672b87ae5b78", "customer@gmail.com", false, "", false, null, "Customer", null, null, null, "0987654321", false, "Customer", "971083d0-1906-4be9-b7fc-0354e504af01", false, null }
                });
        }
    }
}
