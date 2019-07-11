using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PROPlanner.Migrations
{
    public partial class DT2String : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "WorkingDayStart",
                table: "WorkingDay",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "WorkingDayEnd",
                table: "WorkingDay",
                nullable: true,
                oldClrType: typeof(DateTime));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "WorkingDayStart",
                table: "WorkingDay",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "WorkingDayEnd",
                table: "WorkingDay",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
