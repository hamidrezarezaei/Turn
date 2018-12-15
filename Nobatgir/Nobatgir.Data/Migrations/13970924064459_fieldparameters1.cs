using Microsoft.EntityFrameworkCore.Migrations;

namespace _3Nobatgir.Data.Migrations.My
{
    public partial class fieldparameters1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExpertFields_SourceTypes_SourceTypeID",
                schema: "dbo",
                table: "ExpertFields");

            migrationBuilder.AlterColumn<int>(
                name: "SourceTypeID",
                schema: "dbo",
                table: "ExpertFields",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_ExpertFields_SourceTypes_SourceTypeID",
                schema: "dbo",
                table: "ExpertFields",
                column: "SourceTypeID",
                principalSchema: "dbo",
                principalTable: "SourceTypes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExpertFields_SourceTypes_SourceTypeID",
                schema: "dbo",
                table: "ExpertFields");

            migrationBuilder.AlterColumn<int>(
                name: "SourceTypeID",
                schema: "dbo",
                table: "ExpertFields",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ExpertFields_SourceTypes_SourceTypeID",
                schema: "dbo",
                table: "ExpertFields",
                column: "SourceTypeID",
                principalSchema: "dbo",
                principalTable: "SourceTypes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
