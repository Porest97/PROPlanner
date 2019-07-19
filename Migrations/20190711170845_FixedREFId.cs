using Microsoft.EntityFrameworkCore.Migrations;

namespace PROPlanner.Migrations
{
    public partial class FixedREFId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Match_Referee_RerfereeId1",
                table: "Match");

            migrationBuilder.DropIndex(
                name: "IX_Match_RerfereeId1",
                table: "Match");

            migrationBuilder.DropColumn(
                name: "RerfereeId1",
                table: "Match");

            migrationBuilder.CreateIndex(
                name: "IX_Match_RefereeId1",
                table: "Match",
                column: "RefereeId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Match_Referee_RefereeId1",
                table: "Match",
                column: "RefereeId1",
                principalTable: "Referee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Match_Referee_RefereeId1",
                table: "Match");

            migrationBuilder.DropIndex(
                name: "IX_Match_RefereeId1",
                table: "Match");

            migrationBuilder.AddColumn<int>(
                name: "RerfereeId1",
                table: "Match",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Match_RerfereeId1",
                table: "Match",
                column: "RerfereeId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Match_Referee_RerfereeId1",
                table: "Match",
                column: "RerfereeId1",
                principalTable: "Referee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
