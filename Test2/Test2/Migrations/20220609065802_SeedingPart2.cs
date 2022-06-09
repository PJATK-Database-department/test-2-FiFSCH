using Microsoft.EntityFrameworkCore.Migrations;

namespace Test2.Migrations
{
    public partial class SeedingPart2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert into Inspection VALUES(1,1,GETDATE(),'Comment1')");
            migrationBuilder.Sql("Insert into Inspection VALUES(2,2,GETDATE(),'Comment2')");
            migrationBuilder.Sql("Insert into ServiceTypeDictInspection VALUES(1,1,'Comment1')");
            migrationBuilder.Sql("Insert into ServiceTypeDictInspection VALUES(2,2,'Comment2')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from inspection");
            migrationBuilder.Sql("Delete from ServiceTypeDictInspection");
        }
    }
}
