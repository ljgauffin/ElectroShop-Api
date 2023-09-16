using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ElectroShop.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Description" },
                values: new object[,]
                {
                    { new Guid("b3a3096e-4274-4799-a843-380868d4831c"), "Heladeras" },
                    { new Guid("b3a3096e-4274-4799-a843-380868d4832c"), "Notebooks" },
                    { new Guid("b3a3096e-4274-4799-a843-380868d4833c"), "Celulares" },
                    { new Guid("b3a3096e-4274-4799-a843-380868d4834c"), "Mouses" },
                    { new Guid("b3a3096e-4274-4799-a843-380868d4835c"), "Teclados" },
                    { new Guid("b3a3096e-4274-4799-a843-380868d4836c"), "Auriculares" },
                    { new Guid("b3a3096e-4274-4799-a843-380868d4837c"), "Tablets" },
                    { new Guid("b3a3096e-4274-4799-a843-380868d4838c"), "TVs" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
