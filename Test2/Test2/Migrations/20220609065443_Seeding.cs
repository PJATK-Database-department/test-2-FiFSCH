using Microsoft.EntityFrameworkCore.Migrations;

namespace Test2.Migrations
{
    public partial class Seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert into car VALUES('Car1', 2022);");
            migrationBuilder.Sql("Insert into car VALUES('Car2', 2021);");
            migrationBuilder.Sql("Insert into Mechanic VALUES('Mechanic1', 'LastName1');");
            migrationBuilder.Sql("Insert into Mechanic VALUES('Mechanic2', 'LastName2');");
            migrationBuilder.Sql("Insert into ServiceTypeDict VALUES('Type1', 100.0);");
            migrationBuilder.Sql("Insert into ServiceTypeDict VALUES('Type2', 200.0);");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from car;");
            migrationBuilder.Sql("Delete from mechanic;");
            migrationBuilder.Sql("Delete from ServiceTypeDict;");
        }
    }
}
