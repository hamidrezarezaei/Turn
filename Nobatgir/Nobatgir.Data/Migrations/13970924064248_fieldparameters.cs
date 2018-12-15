using Microsoft.EntityFrameworkCore.Migrations;

namespace _3Nobatgir.Data.Migrations.My
{
    public partial class fieldparameters : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Value",
                schema: "dbo",
                table: "ExpertFields",
                newName: "Placeholder");

            migrationBuilder.AddColumn<string>(
                name: "DefaultValue",
                schema: "dbo",
                table: "ExpertFields",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FieldText",
                schema: "dbo",
                table: "ExpertFields",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DefaultValue",
                schema: "dbo",
                table: "ExpertFields");

            migrationBuilder.DropColumn(
                name: "FieldText",
                schema: "dbo",
                table: "ExpertFields");

            migrationBuilder.RenameColumn(
                name: "Placeholder",
                schema: "dbo",
                table: "ExpertFields",
                newName: "Value");
        }
    }
}
