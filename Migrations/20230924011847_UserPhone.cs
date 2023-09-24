using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElectroShop.Migrations
{
    /// <inheritdoc />
    public partial class UserPhone : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Users",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "PhoneValidatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "CartId",
                keyValue: new Guid("b3a3096e-4274-4799-a843-380868d4843c"),
                column: "DateTime",
                value: new DateTime(2023, 9, 23, 22, 18, 47, 145, DateTimeKind.Local).AddTicks(7817));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "CartId",
                keyValue: new Guid("b3a3096e-4274-4799-a843-380868d4844c"),
                column: "DateTime",
                value: new DateTime(2023, 9, 23, 22, 18, 47, 145, DateTimeKind.Local).AddTicks(8137));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "CartId",
                keyValue: new Guid("b3a3096e-4274-4799-a843-380868d4845c"),
                column: "DateTime",
                value: new DateTime(2023, 9, 23, 22, 18, 47, 145, DateTimeKind.Local).AddTicks(8142));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("b3a3096e-4274-4799-a843-380868d4841c"),
                columns: new[] { "PhoneNumber", "PhoneValidatedAt" },
                values: new object[] { "455454554", new DateTime(2023, 9, 23, 22, 18, 47, 143, DateTimeKind.Local).AddTicks(1969) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("b3a3096e-4274-4799-a843-380868d4842c"),
                columns: new[] { "PhoneNumber", "PhoneValidatedAt" },
                values: new object[] { "1234567899", new DateTime(2023, 9, 23, 22, 18, 47, 145, DateTimeKind.Local).AddTicks(5843) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("b3a3096e-4274-4799-a843-380868d4843c"),
                columns: new[] { "PhoneNumber", "PhoneValidatedAt" },
                values: new object[] { "1234567878", new DateTime(2023, 9, 23, 22, 18, 47, 145, DateTimeKind.Local).AddTicks(5863) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PhoneValidatedAt",
                table: "Users");

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
    }
}
