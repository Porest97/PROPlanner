using Microsoft.EntityFrameworkCore.Migrations;

namespace PROPlanner.Migrations
{
    public partial class Int2StringInGameCategoryName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "GameCategoryName",
                table: "GameCategory",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "GameCategoryName",
                table: "GameCategory",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
