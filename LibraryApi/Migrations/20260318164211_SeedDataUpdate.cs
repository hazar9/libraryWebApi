using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibraryApi.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Roman" },
                    { 2, "Bilim Kurgu" },
                    { 3, "Tarih" },
                    { 4, "Yazılım" },
                    { 5, "Psikoloji" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CategoryId", "PageCount", "PublishDate", "Title" },
                values: new object[,]
                {
                    { 1, "Mustafa Kemal Atatürk", 3, 600, new DateTime(1927, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nutuk" },
                    { 2, "José Mauro de Vasconcelos", 1, 182, new DateTime(1968, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Şeker Portakalı" },
                    { 3, "Frank Herbert", 2, 712, new DateTime(1965, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dune" },
                    { 4, "Robert C. Martin", 4, 464, new DateTime(2008, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clean Code" },
                    { 5, "Fyodor Dostoyevski", 1, 687, new DateTime(1866, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Suç ve Ceza" },
                    { 6, "George Orwell", 2, 328, new DateTime(1949, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "1984" },
                    { 7, "Yuval Noah Harari", 3, 412, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sapiens" },
                    { 8, "Paulo Coelho", 1, 188, new DateTime(1988, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Simyacı" },
                    { 9, "James Clear", 5, 320, new DateTime(2018, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Atomik Alışkanlıklar" },
                    { 10, "Sabahattin Ali", 1, 160, new DateTime(1943, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kürk Mantolu Madonna" },
                    { 11, "Oğuz Atay", 1, 724, new DateTime(1971, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tutunamayanlar" },
                    { 12, "Aldous Huxley", 2, 272, new DateTime(1932, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cesur Yeni Dünya" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
