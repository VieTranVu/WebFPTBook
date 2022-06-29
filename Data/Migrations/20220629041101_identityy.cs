using Microsoft.EntityFrameworkCore.Migrations;

namespace WebFPTBook.Data.Migrations
{
    public partial class identityy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ae371076-e856-4d36-b2de-77ed280bd44e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bfd962fc-cdcb-494b-9234-c0075e0e7813");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                value: "10546dbe-5fb7-4ab0-b52b-de5435d826a6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "bc0e5f60-3286-45e2-a936-cde23dce7ab1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "b06c5e34-6e29-401a-9b59-740df24998ff");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "Image", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Roles", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "ae371076-e856-4d36-b2de-77ed280bd44e", 0, "eeabf7ec-667e-43d9-87d8-a6173b8de922", "admin@gmail.com", false, "", false, null, "Admin", null, null, null, "0123456789", false, "Admin", "782748fd-e8ab-43f5-812d-89598906afc6", false, null },
                    { "bfd962fc-cdcb-494b-9234-c0075e0e7813", 0, "244bc8b4-99e6-4f25-a71a-34e0f5b1dec5", "customer@gmail.com", false, "", false, null, "Customer", null, null, null, "0987654321", false, "Customer", "35168fea-d872-404d-8018-575750a51686", false, null }
                });
        }
    }
}
