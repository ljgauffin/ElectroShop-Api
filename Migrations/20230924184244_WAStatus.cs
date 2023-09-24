using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElectroShop.Migrations
{
    /// <inheritdoc />
    public partial class WAStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WAStatus",
                columns: table => new
                {
                    PhoneNumber = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfTries = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WAStatus", x => x.PhoneNumber);
                });

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "CartId",
                keyValue: new Guid("b3a3096e-4274-4799-a843-380868d4843c"),
                column: "DateTime",
                value: new DateTime(2023, 9, 24, 15, 42, 43, 37, DateTimeKind.Local).AddTicks(1589));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "CartId",
                keyValue: new Guid("b3a3096e-4274-4799-a843-380868d4844c"),
                column: "DateTime",
                value: new DateTime(2023, 9, 24, 15, 42, 43, 37, DateTimeKind.Local).AddTicks(1950));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "CartId",
                keyValue: new Guid("b3a3096e-4274-4799-a843-380868d4845c"),
                column: "DateTime",
                value: new DateTime(2023, 9, 24, 15, 42, 43, 37, DateTimeKind.Local).AddTicks(1955));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("b3a3096e-4274-4799-a843-380868d4841c"),
                column: "PhoneValidatedAt",
                value: new DateTime(2023, 9, 24, 15, 42, 43, 35, DateTimeKind.Local).AddTicks(584));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("b3a3096e-4274-4799-a843-380868d4842c"),
                column: "PhoneValidatedAt",
                value: new DateTime(2023, 9, 24, 15, 42, 43, 36, DateTimeKind.Local).AddTicks(9794));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("b3a3096e-4274-4799-a843-380868d4843c"),
                column: "PhoneValidatedAt",
                value: new DateTime(2023, 9, 24, 15, 42, 43, 36, DateTimeKind.Local).AddTicks(9812));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WAStatus");

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "CartId",
                keyValue: new Guid("b3a3096e-4274-4799-a843-380868d4843c"),
                column: "DateTime",
                value: new DateTime(2023, 9, 24, 0, 57, 12, 290, DateTimeKind.Local).AddTicks(5960));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "CartId",
                keyValue: new Guid("b3a3096e-4274-4799-a843-380868d4844c"),
                column: "DateTime",
                value: new DateTime(2023, 9, 24, 0, 57, 12, 290, DateTimeKind.Local).AddTicks(6285));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "CartId",
                keyValue: new Guid("b3a3096e-4274-4799-a843-380868d4845c"),
                column: "DateTime",
                value: new DateTime(2023, 9, 24, 0, 57, 12, 290, DateTimeKind.Local).AddTicks(6289));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("b3a3096e-4274-4799-a843-380868d4841c"),
                column: "PhoneValidatedAt",
                value: new DateTime(2023, 9, 24, 0, 57, 12, 288, DateTimeKind.Local).AddTicks(7107));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("b3a3096e-4274-4799-a843-380868d4842c"),
                column: "PhoneValidatedAt",
                value: new DateTime(2023, 9, 24, 0, 57, 12, 290, DateTimeKind.Local).AddTicks(4396));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("b3a3096e-4274-4799-a843-380868d4843c"),
                column: "PhoneValidatedAt",
                value: new DateTime(2023, 9, 24, 0, 57, 12, 290, DateTimeKind.Local).AddTicks(4411));
        }
    }
}
