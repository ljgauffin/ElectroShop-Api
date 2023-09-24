using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElectroShop.Migrations
{
    /// <inheritdoc />
    public partial class WAStatusCorrection : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "WAStatus",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "CartId",
                keyValue: new Guid("b3a3096e-4274-4799-a843-380868d4843c"),
                column: "DateTime",
                value: new DateTime(2023, 9, 24, 17, 58, 10, 955, DateTimeKind.Local).AddTicks(4617));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "CartId",
                keyValue: new Guid("b3a3096e-4274-4799-a843-380868d4844c"),
                column: "DateTime",
                value: new DateTime(2023, 9, 24, 17, 58, 10, 955, DateTimeKind.Local).AddTicks(5338));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "CartId",
                keyValue: new Guid("b3a3096e-4274-4799-a843-380868d4845c"),
                column: "DateTime",
                value: new DateTime(2023, 9, 24, 17, 58, 10, 955, DateTimeKind.Local).AddTicks(5344));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("b3a3096e-4274-4799-a843-380868d4841c"),
                column: "PhoneValidatedAt",
                value: new DateTime(2023, 9, 24, 17, 58, 10, 952, DateTimeKind.Local).AddTicks(8699));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("b3a3096e-4274-4799-a843-380868d4842c"),
                column: "PhoneValidatedAt",
                value: new DateTime(2023, 9, 24, 17, 58, 10, 955, DateTimeKind.Local).AddTicks(1523));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("b3a3096e-4274-4799-a843-380868d4843c"),
                column: "PhoneValidatedAt",
                value: new DateTime(2023, 9, 24, 17, 58, 10, 955, DateTimeKind.Local).AddTicks(1558));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "WAStatus",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
    }
}
