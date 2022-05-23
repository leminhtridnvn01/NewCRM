using Microsoft.EntityFrameworkCore.Migrations;

namespace NewCRM.Databases.Migrations
{
    public partial class Rename_Age_Into_YearOfBirth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "age",
                table: "Customers",
                newName: "yearOfBirth");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "yearOfBirth",
                table: "Customers",
                newName: "age");
        }
    }
}
