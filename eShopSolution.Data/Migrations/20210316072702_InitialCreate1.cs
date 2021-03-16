using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class InitialCreate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 16, 14, 27, 2, 435, DateTimeKind.Local).AddTicks(75),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 3, 16, 14, 19, 2, 285, DateTimeKind.Local).AddTicks(4785));

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("82a0b7c3-551b-44a7-8db2-a7352e41c547"), "58c9b1e3-9b96-4e2c-ba58-6668d049e146", "Administrator role", "Admin1", "admin 1" });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "Adress", "ConcurrencyStamp", "DisplayName", "Email", "EmailConfirmed", "Gender", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("82a0b7c3-551b-44a7-8db2-a7352e41c547"), 0, null, "436ca7ee-7926-44b8-b95a-18fde3df127e", " Xuân Lộc", "xuanloc.hcm2018@gmail.com", true, 0, false, null, "xuanloc.hcm2018@gmail.com", "Xuân Lộc", "AQAAAAEAACcQAAAAEHmlf4dCzQ8DLxsfsgA2tA29pO5OI3PmTy3hlfxw3YuccfJjXBxQJnjiP6hpWqyRWA==", null, false, "", false, "User" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 3, 16, 14, 27, 2, 446, DateTimeKind.Local).AddTicks(6856));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("82a0b7c3-551b-44a7-8db2-a7352e41c547"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("82a0b7c3-551b-44a7-8db2-a7352e41c547"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 16, 14, 19, 2, 285, DateTimeKind.Local).AddTicks(4785),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 3, 16, 14, 27, 2, 435, DateTimeKind.Local).AddTicks(75));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 3, 16, 14, 19, 2, 297, DateTimeKind.Local).AddTicks(7281));
        }
    }
}
