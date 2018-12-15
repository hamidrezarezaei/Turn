using Microsoft.EntityFrameworkCore.Migrations;

namespace _3Nobatgir.Data.Migrations.My
{
    public partial class sourcetypeexpert1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SourceTypes_Experts_ExpertID",
                schema: "dbo",
                table: "SourceTypes");

            migrationBuilder.AlterColumn<int>(
                name: "ExpertID",
                schema: "dbo",
                table: "SourceTypes",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_SourceTypes_Experts_ExpertID",
                schema: "dbo",
                table: "SourceTypes",
                column: "ExpertID",
                principalSchema: "dbo",
                principalTable: "Experts",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SourceTypes_Experts_ExpertID",
                schema: "dbo",
                table: "SourceTypes");

            migrationBuilder.AlterColumn<int>(
                name: "ExpertID",
                schema: "dbo",
                table: "SourceTypes",
                nullable: true,
                oldClrType: typeof(int));

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
    }
}
