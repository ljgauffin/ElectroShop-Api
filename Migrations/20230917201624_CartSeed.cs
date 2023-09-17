using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ElectroShop.Migrations
{
    /// <inheritdoc />
    public partial class CartSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "CartId", "DateTime", "ProductId", "PurchaseId", "Quantity", "UserId" },
                values: new object[,]
                {
                    { new Guid("b3a3096e-4274-4799-a843-380868d4843c"), new DateTime(2023, 9, 17, 17, 16, 24, 684, DateTimeKind.Local).AddTicks(7987), new Guid("b3a3096e-4274-4799-a843-380868d4838c"), new Guid("00000000-0000-0000-0000-000000000000"), 0, new Guid("b3a3096e-4274-4799-a843-380868d4841c") },
                    { new Guid("b3a3096e-4274-4799-a843-380868d4844c"), new DateTime(2023, 9, 17, 17, 16, 24, 684, DateTimeKind.Local).AddTicks(8003), new Guid("b3a3096e-4274-4799-a843-380868d4839c"), new Guid("00000000-0000-0000-0000-000000000000"), 0, new Guid("b3a3096e-4274-4799-a843-380868d4841c") },
                    { new Guid("b3a3096e-4274-4799-a843-380868d4845c"), new DateTime(2023, 9, 17, 17, 16, 24, 684, DateTimeKind.Local).AddTicks(8006), new Guid("b3a3096e-4274-4799-a843-380868d4840c"), new Guid("00000000-0000-0000-0000-000000000000"), 0, new Guid("b3a3096e-4274-4799-a843-380868d4841c") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "CartId",
                keyValue: new Guid("b3a3096e-4274-4799-a843-380868d4843c"));

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "CartId",
                keyValue: new Guid("b3a3096e-4274-4799-a843-380868d4844c"));

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "CartId",
                keyValue: new Guid("b3a3096e-4274-4799-a843-380868d4845c"));
        }
    }
}
