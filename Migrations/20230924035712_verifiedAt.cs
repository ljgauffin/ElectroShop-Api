using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElectroShop.Migrations
{
    /// <inheritdoc />
    public partial class verifiedAt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "PhoneValidatedAt",
                table: "Users",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "PhoneValidatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

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
                column: "PhoneValidatedAt",
                value: new DateTime(2023, 9, 23, 22, 18, 47, 143, DateTimeKind.Local).AddTicks(1969));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("b3a3096e-4274-4799-a843-380868d4842c"),
                column: "PhoneValidatedAt",
                value: new DateTime(2023, 9, 23, 22, 18, 47, 145, DateTimeKind.Local).AddTicks(5843));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("b3a3096e-4274-4799-a843-380868d4843c"),
                column: "PhoneValidatedAt",
                value: new DateTime(2023, 9, 23, 22, 18, 47, 145, DateTimeKind.Local).AddTicks(5863));
        }
    }
}
