using Microsoft.EntityFrameworkCore.Migrations;

namespace WebFPTBook.Data.Migrations
{
    public partial class identity2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "66b575f1-24d7-4812-bac7-814577e02705");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e3c600d2-dd8d-4602-ac13-3e65fcbee1da");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                value: "13d6f140-6f75-4c82-80e7-45fc025f90b4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "7582739a-4e11-4ef2-84d2-c862d36848cb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "5158ecfd-4407-4e05-b722-7c6a95ddd785");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "Image", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Roles", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "e3c600d2-dd8d-4602-ac13-3e65fcbee1da", 0, "a7170624-bd83-44ff-a7d6-4d71de64109a", "admin@gmail.com", false, "", false, null, "Admin", null, null, null, "0123456789", false, "Admin", "259a57e7-a82d-4022-bb63-325bfc3a2b4f", false, null },
                    { "66b575f1-24d7-4812-bac7-814577e02705", 0, "c878ce86-c02c-4a08-90c3-678abee69321", "customer@gmail.com", false, "", false, null, "Customer", null, null, null, "0987654321", false, "Customer", "cbd5b8dc-418e-449e-8a23-885049fe871c", false, null }
                });
        }
    }
}
