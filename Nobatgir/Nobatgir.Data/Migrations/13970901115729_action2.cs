using Microsoft.EntityFrameworkCore.Migrations;

namespace Nobatgir.Data.Migrations
{
    public partial class action2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ActionName",
                schema: "dbo",
                table: "Actions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ControllerName",
                schema: "dbo",
                table: "Actions",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActionName",
                schema: "dbo",
                table: "Actions");

            migrationBuilder.DropColumn(
                name: "ControllerName",
                schema: "dbo",
                table: "Actions");
        }
    }
}
