using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarShowroomDBData.Migrations
{
    public partial class Changes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Automobiles_Brands_BrandId",
                table: "Automobiles");

            migrationBuilder.DropForeignKey(
                name: "FK_Automobiles_Equipments_EquipmentId",
                table: "Automobiles");

            migrationBuilder.DropForeignKey(
                name: "FK_Avaibilities_Automobiles_VINAuto",
                table: "Avaibilities");

            migrationBuilder.DropForeignKey(
                name: "FK_Avaibilities_CarShowroom_CarShowroomId",
                table: "Avaibilities");

            migrationBuilder.DropForeignKey(
                name: "FK_Brands_Companies_CompanyName",
                table: "Brands");

            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Workers_HeadManagerId",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_Engines_Companies_CompanyName",
                table: "Engines");

            migrationBuilder.DropForeignKey(
                name: "FK_Equipments_Engines_EngineId",
                table: "Equipments");

            migrationBuilder.DropForeignKey(
                name: "FK_Models_Brands_BrandId",
                table: "Models");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Automobiles_VinAuto",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Workers_Departments_DepartmentId1",
                table: "Workers");

            migrationBuilder.DropForeignKey(
                name: "FK_Workers_Departments_ManagedDepartmentId",
                table: "Workers");

            migrationBuilder.DropIndex(
                name: "IX_Workers_DepartmentId1",
                table: "Workers");

            migrationBuilder.DropIndex(
                name: "IX_Workers_ManagedDepartmentId",
                table: "Workers");

            migrationBuilder.DropIndex(
                name: "IX_Departments_HeadManagerId",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "DepartmentId1",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "ManagedDepartmentId",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "HeadManagerId",
                table: "Departments");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDateTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 9, 9, 57, 24, 780, DateTimeKind.Local).AddTicks(4132),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 3, 18, 26, 39, 646, DateTimeKind.Local).AddTicks(8699));

            migrationBuilder.AlterColumn<int>(
                name: "ProdYearTo",
                table: "Models",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CompanyName",
                table: "Engines",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Departments",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ProdDate",
                table: "Automobiles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 9, 9, 57, 24, 771, DateTimeKind.Local).AddTicks(5245),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 3, 18, 26, 39, 645, DateTimeKind.Local).AddTicks(2321));

            migrationBuilder.CreateTable(
                name: "DepartmentHeadManager",
                columns: table => new
                {
                    HeadManagersWorkerId = table.Column<int>(type: "int", nullable: false),
                    ManagedDepartmentsDepartmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentHeadManager", x => new { x.HeadManagersWorkerId, x.ManagedDepartmentsDepartmentId });
                    table.ForeignKey(
                        name: "FK_DepartmentHeadManager_Departments_ManagedDepartmentsDepartmentId",
                        column: x => x.ManagedDepartmentsDepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DepartmentHeadManager_Workers_HeadManagersWorkerId",
                        column: x => x.HeadManagersWorkerId,
                        principalTable: "Workers",
                        principalColumn: "WorkerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Departments_Name",
                table: "Departments",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentHeadManager_ManagedDepartmentsDepartmentId",
                table: "DepartmentHeadManager",
                column: "ManagedDepartmentsDepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Automobiles_Brands_BrandId",
                table: "Automobiles",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "BrandId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Automobiles_Equipments_EquipmentId",
                table: "Automobiles",
                column: "EquipmentId",
                principalTable: "Equipments",
                principalColumn: "EquipmentId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Avaibilities_Automobiles_VINAuto",
                table: "Avaibilities",
                column: "VINAuto",
                principalTable: "Automobiles",
                principalColumn: "VIN",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Avaibilities_CarShowroom_CarShowroomId",
                table: "Avaibilities",
                column: "CarShowroomId",
                principalTable: "CarShowroom",
                principalColumn: "CarShowroomId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Brands_Companies_CompanyName",
                table: "Brands",
                column: "CompanyName",
                principalTable: "Companies",
                principalColumn: "Name",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Engines_Companies_CompanyName",
                table: "Engines",
                column: "CompanyName",
                principalTable: "Companies",
                principalColumn: "Name",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Equipments_Engines_EngineId",
                table: "Equipments",
                column: "EngineId",
                principalTable: "Engines",
                principalColumn: "EngineId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Models_Brands_BrandId",
                table: "Models",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "BrandId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Automobiles_VinAuto",
                table: "Orders",
                column: "VinAuto",
                principalTable: "Automobiles",
                principalColumn: "VIN",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Automobiles_Brands_BrandId",
                table: "Automobiles");

            migrationBuilder.DropForeignKey(
                name: "FK_Automobiles_Equipments_EquipmentId",
                table: "Automobiles");

            migrationBuilder.DropForeignKey(
                name: "FK_Avaibilities_Automobiles_VINAuto",
                table: "Avaibilities");

            migrationBuilder.DropForeignKey(
                name: "FK_Avaibilities_CarShowroom_CarShowroomId",
                table: "Avaibilities");

            migrationBuilder.DropForeignKey(
                name: "FK_Brands_Companies_CompanyName",
                table: "Brands");

            migrationBuilder.DropForeignKey(
                name: "FK_Engines_Companies_CompanyName",
                table: "Engines");

            migrationBuilder.DropForeignKey(
                name: "FK_Equipments_Engines_EngineId",
                table: "Equipments");

            migrationBuilder.DropForeignKey(
                name: "FK_Models_Brands_BrandId",
                table: "Models");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Automobiles_VinAuto",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "DepartmentHeadManager");

            migrationBuilder.DropIndex(
                name: "IX_Departments_Name",
                table: "Departments");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId1",
                table: "Workers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ManagedDepartmentId",
                table: "Workers",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDateTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 3, 18, 26, 39, 646, DateTimeKind.Local).AddTicks(8699),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 9, 9, 57, 24, 780, DateTimeKind.Local).AddTicks(4132));

            migrationBuilder.AlterColumn<string>(
                name: "ProdYearTo",
                table: "Models",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CompanyName",
                table: "Engines",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Departments",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "HeadManagerId",
                table: "Departments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ProdDate",
                table: "Automobiles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 3, 18, 26, 39, 645, DateTimeKind.Local).AddTicks(2321),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 9, 9, 57, 24, 771, DateTimeKind.Local).AddTicks(5245));

            migrationBuilder.CreateIndex(
                name: "IX_Workers_DepartmentId1",
                table: "Workers",
                column: "DepartmentId1");

            migrationBuilder.CreateIndex(
                name: "IX_Workers_ManagedDepartmentId",
                table: "Workers",
                column: "ManagedDepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_HeadManagerId",
                table: "Departments",
                column: "HeadManagerId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Automobiles_Brands_BrandId",
                table: "Automobiles",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "BrandId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Automobiles_Equipments_EquipmentId",
                table: "Automobiles",
                column: "EquipmentId",
                principalTable: "Equipments",
                principalColumn: "EquipmentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Avaibilities_Automobiles_VINAuto",
                table: "Avaibilities",
                column: "VINAuto",
                principalTable: "Automobiles",
                principalColumn: "VIN",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Avaibilities_CarShowroom_CarShowroomId",
                table: "Avaibilities",
                column: "CarShowroomId",
                principalTable: "CarShowroom",
                principalColumn: "CarShowroomId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Brands_Companies_CompanyName",
                table: "Brands",
                column: "CompanyName",
                principalTable: "Companies",
                principalColumn: "Name",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Workers_HeadManagerId",
                table: "Departments",
                column: "HeadManagerId",
                principalTable: "Workers",
                principalColumn: "WorkerId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Engines_Companies_CompanyName",
                table: "Engines",
                column: "CompanyName",
                principalTable: "Companies",
                principalColumn: "Name");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipments_Engines_EngineId",
                table: "Equipments",
                column: "EngineId",
                principalTable: "Engines",
                principalColumn: "EngineId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Models_Brands_BrandId",
                table: "Models",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "BrandId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Automobiles_VinAuto",
                table: "Orders",
                column: "VinAuto",
                principalTable: "Automobiles",
                principalColumn: "VIN",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Workers_Departments_DepartmentId1",
                table: "Workers",
                column: "DepartmentId1",
                principalTable: "Departments",
                principalColumn: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Workers_Departments_ManagedDepartmentId",
                table: "Workers",
                column: "ManagedDepartmentId",
                principalTable: "Departments",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
