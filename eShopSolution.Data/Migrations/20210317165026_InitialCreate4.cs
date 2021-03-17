using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class InitialCreate4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDefault",
                table: "ProductImages",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 17, 23, 50, 25, 579, DateTimeKind.Local).AddTicks(4737),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 3, 17, 10, 35, 23, 312, DateTimeKind.Local).AddTicks(5157));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("82a0b7c3-551b-44a7-8db2-a7352e41c547"),
                column: "ConcurrencyStamp",
                value: "e40428a4-a343-45f0-8a3e-ab5a1f45022d");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("82a0b7c3-551b-44a7-8db2-a7352e41c547"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "58499bc3-5651-4524-a254-1f70178938e2", "AQAAAAEAACcQAAAAEP3JnLOhODuIHll48Js0Y13+cIndp/zeTWqFjduGv4uUtHT2EwpEU8w7uPKM+SVxKA==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 3, 17, 23, 50, 25, 594, DateTimeKind.Local).AddTicks(1841));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDefault",
                table: "ProductImages");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 17, 10, 35, 23, 312, DateTimeKind.Local).AddTicks(5157),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 3, 17, 23, 50, 25, 579, DateTimeKind.Local).AddTicks(4737));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("82a0b7c3-551b-44a7-8db2-a7352e41c547"),
                column: "ConcurrencyStamp",
                value: "19af0ca1-9bed-40ab-ab7c-720d90a90cf1");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("82a0b7c3-551b-44a7-8db2-a7352e41c547"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f5e90f9d-aa7c-4ad1-abcc-e09412d76bbf", "AQAAAAEAACcQAAAAEHQEfr+F3esZVwITw9Bbeim38RZbzPN00lvruL4yBSzElTu2NbkEiTKXW9AWl2wvqw==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 3, 17, 10, 35, 23, 331, DateTimeKind.Local).AddTicks(6052));
        }
    }
}
