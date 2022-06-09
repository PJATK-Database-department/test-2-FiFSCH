using Microsoft.EntityFrameworkCore.Migrations;

namespace Test2.Migrations
{
    public partial class NewInitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ServiceTypeDict_Inspection_InspectionIdInspection",
                table: "ServiceTypeDict");

            migrationBuilder.DropForeignKey(
                name: "FK_ServiceTypeDict_ServiceTypeDict_ServiceTypeDictIdServiceType",
                table: "ServiceTypeDict");

            migrationBuilder.DropIndex(
                name: "IX_ServiceTypeDict_InspectionIdInspection",
                table: "ServiceTypeDict");

            migrationBuilder.DropIndex(
                name: "IX_ServiceTypeDict_ServiceTypeDictIdServiceType",
                table: "ServiceTypeDict");

            migrationBuilder.DropColumn(
                name: "InspectionIdInspection",
                table: "ServiceTypeDict");

            migrationBuilder.DropColumn(
                name: "ServiceTypeDictIdServiceType",
                table: "ServiceTypeDict");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InspectionIdInspection",
                table: "ServiceTypeDict",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ServiceTypeDictIdServiceType",
                table: "ServiceTypeDict",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ServiceTypeDict_InspectionIdInspection",
                table: "ServiceTypeDict",
                column: "InspectionIdInspection");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceTypeDict_ServiceTypeDictIdServiceType",
                table: "ServiceTypeDict",
                column: "ServiceTypeDictIdServiceType");

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceTypeDict_Inspection_InspectionIdInspection",
                table: "ServiceTypeDict",
                column: "InspectionIdInspection",
                principalTable: "Inspection",
                principalColumn: "IdInspection",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceTypeDict_ServiceTypeDict_ServiceTypeDictIdServiceType",
                table: "ServiceTypeDict",
                column: "ServiceTypeDictIdServiceType",
                principalTable: "ServiceTypeDict",
                principalColumn: "IdServiceType",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
