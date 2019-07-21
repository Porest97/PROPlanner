using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PROPlanner.Migrations
{
    public partial class TeamListsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PlayerPossition",
                table: "Person",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SSN",
                table: "Person",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TeamList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TeamId = table.Column<int>(nullable: true),
                    PersonId = table.Column<int>(nullable: true),
                    PersonId1 = table.Column<int>(nullable: true),
                    PersonId2 = table.Column<int>(nullable: true),
                    PersonId3 = table.Column<int>(nullable: true),
                    PersonId4 = table.Column<int>(nullable: true),
                    PersonId5 = table.Column<int>(nullable: true),
                    PersonId6 = table.Column<int>(nullable: true),
                    PersonId7 = table.Column<int>(nullable: true),
                    PersonId8 = table.Column<int>(nullable: true),
                    PersonId9 = table.Column<int>(nullable: true),
                    PersonId10 = table.Column<int>(nullable: true),
                    PersonId11 = table.Column<int>(nullable: true),
                    PersonId12 = table.Column<int>(nullable: true),
                    PersonId13 = table.Column<int>(nullable: true),
                    PersonId14 = table.Column<int>(nullable: true),
                    PersonId15 = table.Column<int>(nullable: true),
                    PersonId16 = table.Column<int>(nullable: true),
                    PersonId17 = table.Column<int>(nullable: true),
                    PersonId18 = table.Column<int>(nullable: true),
                    PersonId19 = table.Column<int>(nullable: true),
                    PersonId20 = table.Column<int>(nullable: true),
                    PersonId21 = table.Column<int>(nullable: true),
                    PersonId22 = table.Column<int>(nullable: true),
                    PersonId23 = table.Column<int>(nullable: true),
                    PersonId24 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeamList_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TeamList_Person_PersonId1",
                        column: x => x.PersonId1,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TeamList_Person_PersonId10",
                        column: x => x.PersonId10,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TeamList_Person_PersonId11",
                        column: x => x.PersonId11,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TeamList_Person_PersonId12",
                        column: x => x.PersonId12,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TeamList_Person_PersonId13",
                        column: x => x.PersonId13,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TeamList_Person_PersonId14",
                        column: x => x.PersonId14,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TeamList_Person_PersonId15",
                        column: x => x.PersonId15,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TeamList_Person_PersonId16",
                        column: x => x.PersonId16,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TeamList_Person_PersonId17",
                        column: x => x.PersonId17,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TeamList_Person_PersonId18",
                        column: x => x.PersonId18,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TeamList_Person_PersonId19",
                        column: x => x.PersonId19,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TeamList_Person_PersonId2",
                        column: x => x.PersonId2,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TeamList_Person_PersonId20",
                        column: x => x.PersonId20,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TeamList_Person_PersonId21",
                        column: x => x.PersonId21,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TeamList_Person_PersonId22",
                        column: x => x.PersonId22,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TeamList_Person_PersonId23",
                        column: x => x.PersonId23,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TeamList_Person_PersonId24",
                        column: x => x.PersonId24,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TeamList_Person_PersonId3",
                        column: x => x.PersonId3,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TeamList_Person_PersonId4",
                        column: x => x.PersonId4,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TeamList_Person_PersonId5",
                        column: x => x.PersonId5,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TeamList_Person_PersonId6",
                        column: x => x.PersonId6,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TeamList_Person_PersonId7",
                        column: x => x.PersonId7,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TeamList_Person_PersonId8",
                        column: x => x.PersonId8,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TeamList_Person_PersonId9",
                        column: x => x.PersonId9,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TeamList_Team_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Team",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TeamList_PersonId",
                table: "TeamList",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamList_PersonId1",
                table: "TeamList",
                column: "PersonId1");

            migrationBuilder.CreateIndex(
                name: "IX_TeamList_PersonId10",
                table: "TeamList",
                column: "PersonId10");

            migrationBuilder.CreateIndex(
                name: "IX_TeamList_PersonId11",
                table: "TeamList",
                column: "PersonId11");

            migrationBuilder.CreateIndex(
                name: "IX_TeamList_PersonId12",
                table: "TeamList",
                column: "PersonId12");

            migrationBuilder.CreateIndex(
                name: "IX_TeamList_PersonId13",
                table: "TeamList",
                column: "PersonId13");

            migrationBuilder.CreateIndex(
                name: "IX_TeamList_PersonId14",
                table: "TeamList",
                column: "PersonId14");

            migrationBuilder.CreateIndex(
                name: "IX_TeamList_PersonId15",
                table: "TeamList",
                column: "PersonId15");

            migrationBuilder.CreateIndex(
                name: "IX_TeamList_PersonId16",
                table: "TeamList",
                column: "PersonId16");

            migrationBuilder.CreateIndex(
                name: "IX_TeamList_PersonId17",
                table: "TeamList",
                column: "PersonId17");

            migrationBuilder.CreateIndex(
                name: "IX_TeamList_PersonId18",
                table: "TeamList",
                column: "PersonId18");

            migrationBuilder.CreateIndex(
                name: "IX_TeamList_PersonId19",
                table: "TeamList",
                column: "PersonId19");

            migrationBuilder.CreateIndex(
                name: "IX_TeamList_PersonId2",
                table: "TeamList",
                column: "PersonId2");

            migrationBuilder.CreateIndex(
                name: "IX_TeamList_PersonId20",
                table: "TeamList",
                column: "PersonId20");

            migrationBuilder.CreateIndex(
                name: "IX_TeamList_PersonId21",
                table: "TeamList",
                column: "PersonId21");

            migrationBuilder.CreateIndex(
                name: "IX_TeamList_PersonId22",
                table: "TeamList",
                column: "PersonId22");

            migrationBuilder.CreateIndex(
                name: "IX_TeamList_PersonId23",
                table: "TeamList",
                column: "PersonId23");

            migrationBuilder.CreateIndex(
                name: "IX_TeamList_PersonId24",
                table: "TeamList",
                column: "PersonId24");

            migrationBuilder.CreateIndex(
                name: "IX_TeamList_PersonId3",
                table: "TeamList",
                column: "PersonId3");

            migrationBuilder.CreateIndex(
                name: "IX_TeamList_PersonId4",
                table: "TeamList",
                column: "PersonId4");

            migrationBuilder.CreateIndex(
                name: "IX_TeamList_PersonId5",
                table: "TeamList",
                column: "PersonId5");

            migrationBuilder.CreateIndex(
                name: "IX_TeamList_PersonId6",
                table: "TeamList",
                column: "PersonId6");

            migrationBuilder.CreateIndex(
                name: "IX_TeamList_PersonId7",
                table: "TeamList",
                column: "PersonId7");

            migrationBuilder.CreateIndex(
                name: "IX_TeamList_PersonId8",
                table: "TeamList",
                column: "PersonId8");

            migrationBuilder.CreateIndex(
                name: "IX_TeamList_PersonId9",
                table: "TeamList",
                column: "PersonId9");

            migrationBuilder.CreateIndex(
                name: "IX_TeamList_TeamId",
                table: "TeamList",
                column: "TeamId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TeamList");

            migrationBuilder.DropColumn(
                name: "PlayerPossition",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "SSN",
                table: "Person");
        }
    }
}
