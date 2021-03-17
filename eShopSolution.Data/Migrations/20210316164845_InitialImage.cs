using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class InitialImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 16, 23, 48, 43, 842, DateTimeKind.Local).AddTicks(6000),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 3, 16, 14, 27, 2, 435, DateTimeKind.Local).AddTicks(75));

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    productId = table.Column<int>(nullable: false),
                    ImagePath = table.Column<string>(maxLength: 200, nullable: false),
                    Caption = table.Column<string>(maxLength: 200, nullable: true),
                    IsDefaul = table.Column<bool>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    SortOrder = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_productId",
                        column: x => x.productId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_productId",
                table: "ProductImages",
                column: "productId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 16, 14, 27, 2, 435, DateTimeKind.Local).AddTicks(75),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 3, 16, 23, 48, 43, 842, DateTimeKind.Local).AddTicks(6000));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("82a0b7c3-551b-44a7-8db2-a7352e41c547"),
                column: "ConcurrencyStamp",
                value: "58c9b1e3-9b96-4e2c-ba58-6668d049e146");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("82a0b7c3-551b-44a7-8db2-a7352e41c547"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "436ca7ee-7926-44b8-b95a-18fde3df127e", "AQAAAAEAACcQAAAAEHmlf4dCzQ8DLxsfsgA2tA29pO5OI3PmTy3hlfxw3YuccfJjXBxQJnjiP6hpWqyRWA==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 3, 16, 14, 27, 2, 446, DateTimeKind.Local).AddTicks(6856));
        }
    }
}
