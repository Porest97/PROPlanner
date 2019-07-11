using Microsoft.EntityFrameworkCore.Migrations;

namespace PROPlanner.Migrations
{
    public partial class AddedTimeCount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "HoursWorked",
                table: "WorkingDay",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalWorkedHours",
                table: "Schedule",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HoursWorked",
                table: "WorkingDay");

            migrationBuilder.DropColumn(
                name: "TotalWorkedHours",
                table: "Schedule");
        }
    }
}
