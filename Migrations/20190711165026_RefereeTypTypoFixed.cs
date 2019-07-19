using Microsoft.EntityFrameworkCore.Migrations;

namespace PROPlanner.Migrations
{
    public partial class RefereeTypTypoFixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RefreeTypeName",
                table: "RefreeType",
                newName: "RefereeTypeName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RefereeTypeName",
                table: "RefreeType",
                newName: "RefreeTypeName");
        }
    }
}
