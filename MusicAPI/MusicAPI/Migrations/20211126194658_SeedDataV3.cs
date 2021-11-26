using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicAPI.Migrations
{
    public partial class SeedDataV3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AuthorId", "Duration", "GenreId", "Name" },
                values: new object[,]
                {
                    { 1, null, 3.1499999999999999, null, "Poker face" },
                    { 2, null, 3.0499999999999998, null, "50:1" },
                    { 3, null, 3.3500000000000001, null, "Nightingale" },
                    { 4, null, 5.1500000000000004, null, "End of August" },
                    { 5, null, 2.5, null, "Cliff of Galipoli" },
                    { 6, null, 3.1499999999999999, null, "Carolus Rex" },
                    { 7, null, 3.2999999999999998, null, "The Last Stand" },
                    { 8, null, 2.4500000000000002, null, "Look what I found" },
                    { 9, null, 4.0, null, "Alejandro" },
                    { 10, null, 4.25, null, "One's man dream" },
                    { 11, null, 4.3499999999999996, null, "Felitsa" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 11);
        }
    }
}
