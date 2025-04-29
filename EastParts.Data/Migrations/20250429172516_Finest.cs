using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EastParts.Data.Migrations
{
    /// <inheritdoc />
    public partial class Finest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarBrands",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Brand Identification"),
                    Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false, comment: "Brand Name"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Brand Logo")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarBrands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PartCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Category Identification"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Category Name"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Category Image")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CarModels",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Model Identification"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Model Name"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Model Image"),
                    CarBrandId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Brand to whom it belongs")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarModels_CarBrands_CarBrandId",
                        column: x => x.CarBrandId,
                        principalTable: "CarBrands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PartTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Part Type Identification"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Part Type Name"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Part Type Image"),
                    PartCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Part Type belongs to a certain category")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PartTypes_PartCategories_PartCategoryId",
                        column: x => x.PartCategoryId,
                        principalTable: "PartCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Product Identification"),
                    Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false, comment: "Product Name"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Image of the product"),
                    Manufacturer = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false, comment: "Product manufacturer"),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false, comment: "Product description"),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false, comment: "Product price"),
                    CarBrandModelsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Product can be used for certain model")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_CarModels_CarBrandModelsId",
                        column: x => x.CarBrandModelsId,
                        principalTable: "CarModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CarBrands",
                columns: new[] { "Id", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { new Guid("148c46b7-5930-4ce3-8bb0-658fd772c423"), "https://upload.wikimedia.org/wikipedia/commons/4/44/BMW.svg", "BMW" },
                    { new Guid("149c57b8-5930-4ce3-8bb0-658fd772c423"), "https://upload.wikimedia.org/wikipedia/commons/thumb/9/90/Mercedes-Logo.svg/1200px-Mercedes-Logo.svg.png", "Mercedes-Benz" }
                });

            migrationBuilder.InsertData(
                table: "PartCategories",
                columns: new[] { "Id", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { new Guid("367c96b7-5930-4ce3-8bb0-658fd772c423"), "https://www.motortrend.com/uploads/f/31208710.jpg?w=768&width=768&q=75&format=webp", "Brake System" },
                    { new Guid("368c96b7-5930-4ce3-8bb0-658fd772c423"), "https://media.istockphoto.com/id/1414449765/photo/wheel-structure-car-wheel-with-brake-isolated-on-a-white-background-3d-illustration.jpg?s=612x612&w=0&k=20&c=a8zRRvb0cbpPtjC7jMmqjVr5gKcNpx_ruPZJqPwGLYw=", "Wheel Suspension" }
                });

            migrationBuilder.InsertData(
                table: "CarModels",
                columns: new[] { "Id", "CarBrandId", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { new Guid("258c46b7-5930-4ce3-8bb0-658fd772c423"), new Guid("148c46b7-5930-4ce3-8bb0-658fd772c423"), "https://curvaconcepts.com/wp-content/uploads/silver-f30-bmw-340i-c300-4.jpg", "F30 340i" },
                    { new Guid("259c46b7-5930-4ce3-8bb0-658fd772c424"), new Guid("149c57b8-5930-4ce3-8bb0-658fd772c423"), "https://www.litchfieldmotors.com/wp-content/uploads/w204_top_p-1700x850.jpg", "C-63" }
                });

            migrationBuilder.InsertData(
                table: "PartTypes",
                columns: new[] { "Id", "ImageUrl", "Name", "PartCategoryId" },
                values: new object[,]
                {
                    { new Guid("420c96b7-5930-4ce3-8bb0-658fd772c423"), "https://mcprod.gsfcarparts.com/media/catalog/category/brake-pads_2.png", "Brake Pads", new Guid("367c96b7-5930-4ce3-8bb0-658fd772c423") },
                    { new Guid("421c19b3-6030-4ce3-8bb0-658fd772c423"), "https://www.h-r.com/wp-content/uploads/2022/11/HR-Tieferlegungsfedern-1.png", "Sport Springs", new Guid("368c96b7-5930-4ce3-8bb0-658fd772c423") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarModels_CarBrandId",
                table: "CarModels",
                column: "CarBrandId");

            migrationBuilder.CreateIndex(
                name: "IX_PartTypes_PartCategoryId",
                table: "PartTypes",
                column: "PartCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CarBrandModelsId",
                table: "Products",
                column: "CarBrandModelsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PartTypes");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "PartCategories");

            migrationBuilder.DropTable(
                name: "CarModels");

            migrationBuilder.DropTable(
                name: "CarBrands");
        }
    }
}
