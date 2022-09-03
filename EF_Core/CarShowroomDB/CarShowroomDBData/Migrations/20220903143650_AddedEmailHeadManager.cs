using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarShowroomDBData.Migrations
{
    public partial class AddedEmailHeadManager : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Workers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDateTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 3, 17, 36, 49, 760, DateTimeKind.Local).AddTicks(9412),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 3, 17, 35, 56, 796, DateTimeKind.Local).AddTicks(2506));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ProdDate",
                table: "Automobiles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 3, 17, 36, 49, 758, DateTimeKind.Local).AddTicks(5948),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 3, 17, 35, 56, 794, DateTimeKind.Local).AddTicks(7261));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Workers");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDateTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 3, 17, 35, 56, 796, DateTimeKind.Local).AddTicks(2506),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 3, 17, 36, 49, 760, DateTimeKind.Local).AddTicks(9412));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ProdDate",
                table: "Automobiles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 3, 17, 35, 56, 794, DateTimeKind.Local).AddTicks(7261),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 3, 17, 36, 49, 758, DateTimeKind.Local).AddTicks(5948));
        }
    }
}
