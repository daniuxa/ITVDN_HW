using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarShowroomDBData.Migrations
{
    public partial class AddedLists : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDateTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 3, 18, 26, 39, 646, DateTimeKind.Local).AddTicks(8699),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 3, 17, 36, 49, 760, DateTimeKind.Local).AddTicks(9412));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ProdDate",
                table: "Automobiles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 3, 18, 26, 39, 645, DateTimeKind.Local).AddTicks(2321),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 3, 17, 36, 49, 758, DateTimeKind.Local).AddTicks(5948));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDateTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 3, 17, 36, 49, 760, DateTimeKind.Local).AddTicks(9412),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 3, 18, 26, 39, 646, DateTimeKind.Local).AddTicks(8699));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ProdDate",
                table: "Automobiles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 3, 17, 36, 49, 758, DateTimeKind.Local).AddTicks(5948),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 3, 18, 26, 39, 645, DateTimeKind.Local).AddTicks(2321));
        }
    }
}
