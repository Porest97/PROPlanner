using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PROPlanner.Migrations
{
    public partial class GameCategoryAddedToGame : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GameCategoryId",
                table: "Game",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "GameCategory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GameCategoryName = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameCategory", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Game_GameCategoryId",
                table: "Game",
                column: "GameCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Game_GameCategory_GameCategoryId",
                table: "Game",
                column: "GameCategoryId",
                principalTable: "GameCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Game_GameCategory_GameCategoryId",
                table: "Game");

            migrationBuilder.DropTable(
                name: "GameCategory");

            migrationBuilder.DropIndex(
                name: "IX_Game_GameCategoryId",
                table: "Game");

            migrationBuilder.DropColumn(
                name: "GameCategoryId",
                table: "Game");
        }
    }
}
