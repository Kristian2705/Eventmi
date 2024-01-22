using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eventmi.Data.Migrations
{
    public partial class updateNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Start",
                table: "Events",
                newName: "StartDate");

            migrationBuilder.RenameColumn(
                name: "End",
                table: "Events",
                newName: "EndDate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "Events",
                newName: "Start");

            migrationBuilder.RenameColumn(
                name: "EndDate",
                table: "Events",
                newName: "End");
        }
    }
}
