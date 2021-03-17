using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class UpdataImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "FileSize",
                table: "ProductImages",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 17, 9, 41, 51, 336, DateTimeKind.Local).AddTicks(522),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 3, 16, 23, 48, 43, 842, DateTimeKind.Local).AddTicks(6000));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("82a0b7c3-551b-44a7-8db2-a7352e41c547"),
                column: "ConcurrencyStamp",
                value: "7724f2b4-72ac-4f88-92de-9ac157e52380");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("82a0b7c3-551b-44a7-8db2-a7352e41c547"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c5f50f8a-3f4c-48cd-874d-286b5324a58c", "AQAAAAEAACcQAAAAEFiYyoOUipK8w+WLtxuuRuJYu4S8jgENzHrzGbczwr2EpYqsVjRFXSNVKyB0K8JNow==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 3, 17, 9, 41, 51, 348, DateTimeKind.Local).AddTicks(7737));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FileSize",
                table: "ProductImages");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 16, 23, 48, 43, 842, DateTimeKind.Local).AddTicks(6000),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 3, 17, 9, 41, 51, 336, DateTimeKind.Local).AddTicks(522));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("82a0b7c3-551b-44a7-8db2-a7352e41c547"),
                column: "ConcurrencyStamp",
                value: "60615ed5-f769-4b9d-9cd6-7e4a4c7faf56");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("82a0b7c3-551b-44a7-8db2-a7352e41c547"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7261b889-128c-4d4a-a168-4e11c73cc163", "AQAAAAEAACcQAAAAEGq7CNMkDMCzKyrzdgSuYTBru3NY+f+Y0ReQUkcQFmZ+8eayFH6dYUdPRyWnX1eK7g==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 3, 16, 23, 48, 43, 869, DateTimeKind.Local).AddTicks(6564));
        }
    }
}
