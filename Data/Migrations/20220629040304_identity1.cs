using Microsoft.EntityFrameworkCore.Migrations;

namespace WebFPTBook.Data.Migrations
{
    public partial class identity1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "129b92f1-0e16-4867-b030-84611cde320a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99198e2c-6393-4e2d-80cf-6ab950eb3278");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
