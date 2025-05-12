using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EastParts.Data.Migrations
{
    /// <inheritdoc />
    public partial class patch1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CarBrandModelsId", "Description", "ImageUrl", "Manufacturer", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("520c19b6-7030-4ce3-8bb0-658fd772c423"), new Guid("258c46b7-5930-4ce3-8bb0-658fd772c423"), "BREMBO PRIME LINE pads for BMW 3 Series F30/F35/F80 340i", "https://www.autopower.bg/images/%D0%BD%D0%B0%D0%BA%D0%BB%D0%B0%D0%B4%D0%BA%D0%B8-BREMBO-PRIME-LINE-P06088-BMW-3-Sedan-F30-F35-F80-340-i-imagetabig-845520901720541-BREMBO.jpg", "Brembo", "BREMBO PRIME LINE pads", 243.00m },
                    { new Guid("521c29b6-7030-4ce3-8bb0-658fd772c423"), new Guid("259c46b7-5930-4ce3-8bb0-658fd772c424"), "BILSTEIN B3 OE Replacement for Mercedes C-Class W204 C-63 AMG", "https://www.autopower.bg/images/%D0%BF%D1%80%D1%83%D0%B6%D0%B8%D0%BD%D0%B0-BILSTEIN-B3-OE-Replacement-36-292141-Mercedes-C-class-Saloon-w204-C-63-AMG-204.077-imagetabig-845520896800921-BILSTEIN.jpg", "Bilstein", "BILSTEIN B3 OE Replacement", 135.00m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("520c19b6-7030-4ce3-8bb0-658fd772c423"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("521c29b6-7030-4ce3-8bb0-658fd772c423"));
        }
    }
}
