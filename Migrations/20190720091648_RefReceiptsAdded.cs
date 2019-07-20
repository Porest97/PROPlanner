using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PROPlanner.Migrations
{
    public partial class RefReceiptsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BankAccount",
                table: "Referee",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SwishAccount",
                table: "Referee",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "RefReceipt",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MatchId = table.Column<int>(nullable: true),
                    RefereeId = table.Column<int>(nullable: true),
                    RefereeId1 = table.Column<int>(nullable: true),
                    RefereeId2 = table.Column<int>(nullable: true),
                    RefereeId3 = table.Column<int>(nullable: true),
                    REF1Fee = table.Column<int>(nullable: false),
                    REF1Allowance = table.Column<int>(nullable: false),
                    REF1LateGame = table.Column<int>(nullable: false),
                    REF1TravellengthKm = table.Column<int>(nullable: false),
                    REF1TravelKostperkm = table.Column<int>(nullable: false),
                    REF1TravelKost = table.Column<int>(nullable: false),
                    REF1Toll = table.Column<int>(nullable: false),
                    REF1ParkingFee = table.Column<int>(nullable: false),
                    REF1TotalPayment = table.Column<int>(nullable: false),
                    REF1Paid = table.Column<bool>(nullable: false),
                    REF1Date = table.Column<string>(nullable: true),
                    REF1Sign = table.Column<string>(nullable: true),
                    REF1From = table.Column<string>(nullable: true),
                    REF1To = table.Column<string>(nullable: true),
                    REF2Fee = table.Column<int>(nullable: false),
                    REF2Allowance = table.Column<int>(nullable: false),
                    REF2LateGame = table.Column<int>(nullable: false),
                    REF2TravellengthKm = table.Column<int>(nullable: false),
                    REF2TravelKostperkm = table.Column<int>(nullable: false),
                    REF2TravelKost = table.Column<int>(nullable: false),
                    REF2Toll = table.Column<int>(nullable: false),
                    REF2ParkingFee = table.Column<int>(nullable: false),
                    REF2TotalPayment = table.Column<int>(nullable: false),
                    REF2Paid = table.Column<bool>(nullable: false),
                    REF2Date = table.Column<string>(nullable: true),
                    REF2Sign = table.Column<string>(nullable: true),
                    REF2From = table.Column<string>(nullable: true),
                    REF2To = table.Column<string>(nullable: true),
                    REF3Fee = table.Column<int>(nullable: false),
                    REF3Allowance = table.Column<int>(nullable: false),
                    REF3LateGame = table.Column<int>(nullable: false),
                    REF3TravellengthKm = table.Column<int>(nullable: false),
                    REF3TravelKostperkm = table.Column<int>(nullable: false),
                    REF3TravelKost = table.Column<int>(nullable: false),
                    REF3Toll = table.Column<int>(nullable: false),
                    REF3ParkingFee = table.Column<int>(nullable: false),
                    REF3TotalPayment = table.Column<int>(nullable: false),
                    REF3Paid = table.Column<bool>(nullable: false),
                    REF3Date = table.Column<string>(nullable: true),
                    REF3Sign = table.Column<string>(nullable: true),
                    REF3From = table.Column<string>(nullable: true),
                    REF3To = table.Column<string>(nullable: true),
                    REF4Fee = table.Column<int>(nullable: false),
                    REF4Allowance = table.Column<int>(nullable: false),
                    REF4LateGame = table.Column<int>(nullable: false),
                    REF4TravellengthKm = table.Column<int>(nullable: false),
                    REF4TravelKostperkm = table.Column<int>(nullable: false),
                    REF4TravelKost = table.Column<int>(nullable: false),
                    REF4Toll = table.Column<int>(nullable: false),
                    REF4ParkingFee = table.Column<int>(nullable: false),
                    REF4TotalPayment = table.Column<int>(nullable: false),
                    REF4Paid = table.Column<bool>(nullable: false),
                    REF4Date = table.Column<string>(nullable: true),
                    REF4Sign = table.Column<string>(nullable: true),
                    REF4From = table.Column<string>(nullable: true),
                    REF4To = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefReceipt", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RefReceipt_Match_MatchId",
                        column: x => x.MatchId,
                        principalTable: "Match",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RefReceipt_Referee_RefereeId",
                        column: x => x.RefereeId,
                        principalTable: "Referee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RefReceipt_Referee_RefereeId1",
                        column: x => x.RefereeId1,
                        principalTable: "Referee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RefReceipt_Referee_RefereeId2",
                        column: x => x.RefereeId2,
                        principalTable: "Referee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RefReceipt_Referee_RefereeId3",
                        column: x => x.RefereeId3,
                        principalTable: "Referee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RefReceipt_MatchId",
                table: "RefReceipt",
                column: "MatchId");

            migrationBuilder.CreateIndex(
                name: "IX_RefReceipt_RefereeId",
                table: "RefReceipt",
                column: "RefereeId");

            migrationBuilder.CreateIndex(
                name: "IX_RefReceipt_RefereeId1",
                table: "RefReceipt",
                column: "RefereeId1");

            migrationBuilder.CreateIndex(
                name: "IX_RefReceipt_RefereeId2",
                table: "RefReceipt",
                column: "RefereeId2");

            migrationBuilder.CreateIndex(
                name: "IX_RefReceipt_RefereeId3",
                table: "RefReceipt",
                column: "RefereeId3");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RefReceipt");

            migrationBuilder.DropColumn(
                name: "BankAccount",
                table: "Referee");

            migrationBuilder.DropColumn(
                name: "SwishAccount",
                table: "Referee");
        }
    }
}
