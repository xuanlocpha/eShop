using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class UpdataImage1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_Products_productId",
                table: "ProductImages");

            migrationBuilder.RenameColumn(
                name: "productId",
                table: "ProductImages",
                newName: "ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductImages_productId",
                table: "ProductImages",
                newName: "IX_ProductImages_ProductId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 17, 10, 35, 23, 312, DateTimeKind.Local).AddTicks(5157),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 3, 17, 9, 41, 51, 336, DateTimeKind.Local).AddTicks(522));

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

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_Products_ProductId",
                table: "ProductImages",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_Products_ProductId",
                table: "ProductImages");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "ProductImages",
                newName: "productId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                newName: "IX_ProductImages_productId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 17, 9, 41, 51, 336, DateTimeKind.Local).AddTicks(522),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 3, 17, 10, 35, 23, 312, DateTimeKind.Local).AddTicks(5157));

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

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_Products_productId",
                table: "ProductImages",
                column: "productId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
