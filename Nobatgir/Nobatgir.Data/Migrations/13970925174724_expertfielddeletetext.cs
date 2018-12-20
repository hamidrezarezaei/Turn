using Microsoft.EntityFrameworkCore.Migrations;

namespace _3Nobatgir.Data.Migrations.My
{
    public partial class expertfielddeletetext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FieldText",
                schema: "dbo",
                table: "ExpertFields");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FieldText",
                schema: "dbo",
                table: "ExpertFields",
                nullable: true);
        }
    }
}
