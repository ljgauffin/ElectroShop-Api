using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElectroShop.Migrations
{
    /// <inheritdoc />
    public partial class ChangeSeeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "CartId",
                keyValue: new Guid("b3a3096e-4274-4799-a843-380868d4843c"),
                column: "DateTime",
                value: new DateTime(2023, 9, 17, 17, 28, 27, 813, DateTimeKind.Local).AddTicks(2165));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "CartId",
                keyValue: new Guid("b3a3096e-4274-4799-a843-380868d4844c"),
                column: "DateTime",
                value: new DateTime(2023, 9, 17, 17, 28, 27, 815, DateTimeKind.Local).AddTicks(239));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "CartId",
                keyValue: new Guid("b3a3096e-4274-4799-a843-380868d4845c"),
                column: "DateTime",
                value: new DateTime(2023, 9, 17, 17, 28, 27, 815, DateTimeKind.Local).AddTicks(253));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "CartId",
                keyValue: new Guid("b3a3096e-4274-4799-a843-380868d4843c"),
                column: "DateTime",
                value: new DateTime(2023, 9, 17, 17, 16, 24, 684, DateTimeKind.Local).AddTicks(7987));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "CartId",
                keyValue: new Guid("b3a3096e-4274-4799-a843-380868d4844c"),
                column: "DateTime",
                value: new DateTime(2023, 9, 17, 17, 16, 24, 684, DateTimeKind.Local).AddTicks(8003));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "CartId",
                keyValue: new Guid("b3a3096e-4274-4799-a843-380868d4845c"),
                column: "DateTime",
                value: new DateTime(2023, 9, 17, 17, 16, 24, 684, DateTimeKind.Local).AddTicks(8006));
        }
    }
}
