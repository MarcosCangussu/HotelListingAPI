using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotelListingAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedCountriesAndHotels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "Id", "Name", "ShortName" },
                values: new object[,]
                {
                    { 1, "Brazil", "BR" },
                    { 2, "Australia", "AU" },
                    { 3, "Canada", "CA" }
                });

            migrationBuilder.InsertData(
                table: "hotels",
                columns: new[] { "Id", "Address", "CountryId", "CountryId1", "Name", "Rating" },
                values: new object[,]
                {
                    { 1, "Belo Horizonte", 1.0, null, "Brasilian Hotel", 4.5 },
                    { 2, "Sydney", 2.0, null, "Australian Hotel", 4.7000000000000002 },
                    { 3, "Toronto", 3.0, null, "Canadian Hotel", 4.5999999999999996 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "hotels",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "hotels",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "hotels",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
