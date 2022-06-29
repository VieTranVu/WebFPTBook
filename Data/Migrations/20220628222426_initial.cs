using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebFPTBook.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Roles",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Image = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Image = table.Column<string>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<int>(nullable: false),
                    Order_Date = table.Column<DateTime>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", "3b5ad566-752e-4f7e-b160-0008ca42fd17", "Admin", "ADMIN" },
                    { "2", "52e39d00-8981-4f93-bd16-9ea6960c7a6d", "Store Owner", "STORE OWNER" },
                    { "3", "d8f51795-1b24-46c2-9c58-0ffa0446372c", "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "Image", "Name", "Roles" },
                values: new object[,]
                {
                    { "00d91d97-1e24-4b30-9e95-f6e1033969a3", 0, "8ac504ad-c1fc-4073-aa32-b4b563c6d273", "User", "admin@gmail.com", false, false, null, null, null, null, "0321169923", false, "04c466a2-36d8-4cbb-a95c-0ab46b6defaf", false, null, "", "Admin", "Admin" },
                    { "b26071a7-193e-4a73-9a76-925cc4591b6d", 0, "c42ed69e-4ac7-45de-95c8-eaa81f3a03cf", "User", "customer@gmail.com", false, false, null, null, null, null, "0321333923", false, "e47b835b-7914-42cd-a2f5-22e81792a828", false, null, "", "Customer", "Customer" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Image", "Name" },
                values: new object[,]
                {
                    { 1, "https://prod-ripcut-delivery.disney-plus.net/v1/variant/disney/81BA14190C0DB4241EB4AD72ECC0CE70A13F58A52431057CB53AEB551BF86386/scale?width=1200&aspectRatio=1.78&format=jpeg", "Horror" },
                    { 2, "http://findingada.com/wp-content/uploads/2013/10/A-Passion-for-Science-cover.jpeg", "Science" },
                    { 3, "https://d28hgpri8am2if.cloudfront.net/book_images/onix/cvr9781628724431/masterpieces-of-the-english-short-novel-9781628724431_hr.jpg", "Novel" },
                    { 4, "https://www.davibooks.vn/stores/uploads/h/300__49926_big.jpg", "Comic" },
                    { 5, "https://m.media-amazon.com/images/I/51MicQZzKEL.jpg", "Romance" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "CategoryId", "Description", "Image", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, "A family flees the crime-ridden city—and finds something worse—in “a brilliantly imagined horror story” by the New York Times–bestselling author (The Boston Globe).", "https://images-na.ssl-images-amazon.com/images/I/5147HWXW8OL._SX326_BO1,204,203,200_.jpg", "Harvest Home", 15.0 },
                    { 2, 2, "Charles Darwin’s classic that exploded into public controversy, revolutionized the course of science, and continues to transform our views of the world.", "https://salt.tikicdn.com/cache/400x400/ts/product/13/1e/20/77b87c3248a57a6d01c6b5bcce310cbc.jpg.webp", "Signet Classics", 5.0 },
                    { 3, 3, "I am not a bird, no cage can trap me. I am a free man, with an independent will", "https://cdn0.fahasa.com/media/catalog/product/8/9/8935095621453.jpg", "Jane Eyre", 6.0 },
                    { 4, 4, "Doraemon, a cat robot, traveled back in time from the 22nd century to watch over Noby who’s a good kid but terrible at sports, never studies, and has an incredible capacity for slacking off. Doraemon tries to help Noby with nice but often unpredictable gadgets from his 4th dimensional pocket as Noby’s clumsy and always getting into trouble. Can Doraemon solve the problems and change Noby’s fortune for the better?", "https://m.media-amazon.com/images/I/81nDqEEt-gL._CLa%7C2328,2048%7C81VQH+klyLL.jpg,810kEFirnWL.jpg%7C0,0,1536,2048+1576,0,752,1003+1576,1043,752,1003_._SY300_.jpg", "DORAEMON", 10.0 },
                    { 5, 5, "The classic minute-by-minute account of the sinking of the Titanic, in a 50th anniversary edition with a new introduction by Nathaniel Philbrick", "https://images-na.ssl-images-amazon.com/images/I/51FCgfUVCqL._SY291_BO1,204,203,200_QL40_FMwebp_.jpg", "Night to Remember", 26.0 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "BookId", "Order_Date", "Quantity", "UserId" },
                values: new object[] { 1, 1, new DateTime(2021, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "BookId", "Order_Date", "Quantity", "UserId" },
                values: new object[] { 2, 2, new DateTime(2022, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, null });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "BookId", "Order_Date", "Quantity", "UserId" },
                values: new object[] { 3, 5, new DateTime(2022, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, null });

            migrationBuilder.CreateIndex(
                name: "IX_Books_CategoryId",
                table: "Books",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_BookId",
                table: "Orders",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00d91d97-1e24-4b30-9e95-f6e1033969a3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b26071a7-193e-4a73-9a76-925cc4591b6d");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Roles",
                table: "AspNetUsers");
        }
    }
}
