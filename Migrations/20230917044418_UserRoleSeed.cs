using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ElectroShop.Migrations
{
    /// <inheritdoc />
    public partial class UserRoleSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40);

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Users_Email",
                table: "Users",
                column: "Email");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "Description" },
                values: new object[,]
                {
                    { new Guid("b3a3096e-4274-4799-a843-380868d4844c"), "User" },
                    { new Guid("b3a3096e-4274-4799-a843-380868d4845c"), "Seller" },
                    { new Guid("b3a3096e-4274-4799-a843-380868d4846c"), "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Email", "Name", "Password", "RoleId", "Surname" },
                values: new object[,]
                {
                    { new Guid("b3a3096e-4274-4799-a843-380868d4841c"), "juan@perez.com", "Juan", "12345678", new Guid("b3a3096e-4274-4799-a843-380868d4844c"), "Perez" },
                    { new Guid("b3a3096e-4274-4799-a843-380868d4842c"), "pedro@gozales.com", "Pedro", "12345678", new Guid("b3a3096e-4274-4799-a843-380868d4845c"), "Gonzales" },
                    { new Guid("b3a3096e-4274-4799-a843-380868d4843c"), "Mario@ramirez.com", "Mario", "12345678", new Guid("b3a3096e-4274-4799-a843-380868d4846c"), "Ramirez" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "RoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Users_Email",
                table: "Users");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("b3a3096e-4274-4799-a843-380868d4841c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("b3a3096e-4274-4799-a843-380868d4842c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("b3a3096e-4274-4799-a843-380868d4843c"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("b3a3096e-4274-4799-a843-380868d4844c"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("b3a3096e-4274-4799-a843-380868d4845c"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("b3a3096e-4274-4799-a843-380868d4846c"));

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "RoleId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
