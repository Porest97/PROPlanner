using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PROPlanner.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CompanyName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersonType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PersonTypeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WorkingDay",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    WorkingDayName = table.Column<string>(nullable: true),
                    WorkingDayStart = table.Column<DateTime>(nullable: false),
                    WorkingDayEnd = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkingDay", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    StreetAddress = table.Column<string>(nullable: true),
                    ZipCode = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    PhoneNumber1 = table.Column<string>(nullable: true),
                    PhoneNumber2 = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    PersonTypeId = table.Column<int>(nullable: true),
                    CompanyId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Person_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Person_PersonType_PersonTypeId",
                        column: x => x.PersonTypeId,
                        principalTable: "PersonType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Schedule",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ScheduleStartDate = table.Column<DateTime>(nullable: false),
                    ScheduleEndDate = table.Column<DateTime>(nullable: false),
                    ScheduleWeek = table.Column<string>(nullable: true),
                    ScheduleName = table.Column<string>(nullable: true),
                    ScheduleDescription = table.Column<string>(nullable: true),
                    PersonId = table.Column<int>(nullable: true),
                    WorkingDayId = table.Column<int>(nullable: true),
                    WorkingDayId1 = table.Column<int>(nullable: true),
                    WorkingDayId2 = table.Column<int>(nullable: true),
                    WorkingDayId3 = table.Column<int>(nullable: true),
                    WorkingDayId4 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedule", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Schedule_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Schedule_WorkingDay_WorkingDayId",
                        column: x => x.WorkingDayId,
                        principalTable: "WorkingDay",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Schedule_WorkingDay_WorkingDayId1",
                        column: x => x.WorkingDayId1,
                        principalTable: "WorkingDay",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Schedule_WorkingDay_WorkingDayId2",
                        column: x => x.WorkingDayId2,
                        principalTable: "WorkingDay",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Schedule_WorkingDay_WorkingDayId3",
                        column: x => x.WorkingDayId3,
                        principalTable: "WorkingDay",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Schedule_WorkingDay_WorkingDayId4",
                        column: x => x.WorkingDayId4,
                        principalTable: "WorkingDay",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Person_CompanyId",
                table: "Person",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_PersonTypeId",
                table: "Person",
                column: "PersonTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedule_PersonId",
                table: "Schedule",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedule_WorkingDayId",
                table: "Schedule",
                column: "WorkingDayId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedule_WorkingDayId1",
                table: "Schedule",
                column: "WorkingDayId1");

            migrationBuilder.CreateIndex(
                name: "IX_Schedule_WorkingDayId2",
                table: "Schedule",
                column: "WorkingDayId2");

            migrationBuilder.CreateIndex(
                name: "IX_Schedule_WorkingDayId3",
                table: "Schedule",
                column: "WorkingDayId3");

            migrationBuilder.CreateIndex(
                name: "IX_Schedule_WorkingDayId4",
                table: "Schedule",
                column: "WorkingDayId4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Schedule");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "WorkingDay");

            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "PersonType");
        }
    }
}
