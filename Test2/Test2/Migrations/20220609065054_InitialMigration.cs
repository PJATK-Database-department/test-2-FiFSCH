using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Test2.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Car",
                columns: table => new
                {
                    IdCar = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ProductionYear = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Car", x => x.IdCar);
                });

            migrationBuilder.CreateTable(
                name: "Mechanic",
                columns: table => new
                {
                    IdMechanic = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mechanic", x => x.IdMechanic);
                });

            migrationBuilder.CreateTable(
                name: "Inspection",
                columns: table => new
                {
                    IdInspection = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCar = table.Column<int>(type: "int", nullable: false),
                    IdMechanic = table.Column<int>(type: "int", nullable: false),
                    InspectionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inspection", x => x.IdInspection);
                    table.ForeignKey(
                        name: "FK_Inspection_Car_IdCar",
                        column: x => x.IdCar,
                        principalTable: "Car",
                        principalColumn: "IdCar",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Inspection_Mechanic_IdMechanic",
                        column: x => x.IdMechanic,
                        principalTable: "Mechanic",
                        principalColumn: "IdMechanic",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ServiceTypeDict",
                columns: table => new
                {
                    IdServiceType = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceType = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    InspectionIdInspection = table.Column<int>(type: "int", nullable: true),
                    ServiceTypeDictIdServiceType = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceTypeDict", x => x.IdServiceType);
                    table.ForeignKey(
                        name: "FK_ServiceTypeDict_Inspection_InspectionIdInspection",
                        column: x => x.InspectionIdInspection,
                        principalTable: "Inspection",
                        principalColumn: "IdInspection",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ServiceTypeDict_ServiceTypeDict_ServiceTypeDictIdServiceType",
                        column: x => x.ServiceTypeDictIdServiceType,
                        principalTable: "ServiceTypeDict",
                        principalColumn: "IdServiceType",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ServiceTypeDictInspection",
                columns: table => new
                {
                    IdServiceType = table.Column<int>(type: "int", nullable: false),
                    IdInspection = table.Column<int>(type: "int", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceTypeDictInspection", x => new { x.IdServiceType, x.IdInspection });
                    table.ForeignKey(
                        name: "FK_ServiceTypeDictInspection_Inspection_IdInspection",
                        column: x => x.IdInspection,
                        principalTable: "Inspection",
                        principalColumn: "IdInspection",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServiceTypeDictInspection_ServiceTypeDict_IdServiceType",
                        column: x => x.IdServiceType,
                        principalTable: "ServiceTypeDict",
                        principalColumn: "IdServiceType",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Inspection_IdCar",
                table: "Inspection",
                column: "IdCar");

            migrationBuilder.CreateIndex(
                name: "IX_Inspection_IdMechanic",
                table: "Inspection",
                column: "IdMechanic");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceTypeDict_InspectionIdInspection",
                table: "ServiceTypeDict",
                column: "InspectionIdInspection");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceTypeDict_ServiceTypeDictIdServiceType",
                table: "ServiceTypeDict",
                column: "ServiceTypeDictIdServiceType");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceTypeDictInspection_IdInspection",
                table: "ServiceTypeDictInspection",
                column: "IdInspection");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ServiceTypeDictInspection");

            migrationBuilder.DropTable(
                name: "ServiceTypeDict");

            migrationBuilder.DropTable(
                name: "Inspection");

            migrationBuilder.DropTable(
                name: "Car");

            migrationBuilder.DropTable(
                name: "Mechanic");
        }
    }
}
