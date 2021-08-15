using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PatrykKaczynskiLab4ZadDom.Migrations
{
    public partial class Secondmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "timeCreation",
                table: "TaskViewModels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "timeEdition",
                table: "TaskViewModels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "timeCreation",
                table: "TaskViewModels");

            migrationBuilder.DropColumn(
                name: "timeEdition",
                table: "TaskViewModels");
        }
    }
}
