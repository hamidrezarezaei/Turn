using Microsoft.EntityFrameworkCore.Migrations;

namespace _3Nobatgir.Data.Migrations.My
{
    public partial class sourcetypeexpert : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ExpertID",
                schema: "dbo",
                table: "SourceTypes",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SourceTypes_ExpertID",
                schema: "dbo",
                table: "SourceTypes",
                column: "ExpertID");

            migrationBuilder.AddForeignKey(
                name: "FK_SourceTypes_Experts_ExpertID",
                schema: "dbo",
                table: "SourceTypes",
                column: "ExpertID",
                principalSchema: "dbo",
                principalTable: "Experts",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SourceTypes_Experts_ExpertID",
                schema: "dbo",
                table: "SourceTypes");

            migrationBuilder.DropIndex(
                name: "IX_SourceTypes_ExpertID",
                schema: "dbo",
                table: "SourceTypes");

            migrationBuilder.DropColumn(
                name: "ExpertID",
                schema: "dbo",
                table: "SourceTypes");
        }
    }
}
