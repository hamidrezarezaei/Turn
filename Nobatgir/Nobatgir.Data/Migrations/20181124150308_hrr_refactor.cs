using Microsoft.EntityFrameworkCore.Migrations;

namespace Nobatgir.Data.Migrations
{
    public partial class hrr_refactor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Experts_Sites_SiteID",
                schema: "dbo",
                table: "Experts");

            migrationBuilder.AlterColumn<int>(
                name: "SiteID",
                schema: "dbo",
                table: "Experts",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SiteID",
                schema: "dbo",
                table: "Categories",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_SiteID",
                schema: "dbo",
                table: "Categories",
                column: "SiteID");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Sites_SiteID",
                schema: "dbo",
                table: "Categories",
                column: "SiteID",
                principalSchema: "dbo",
                principalTable: "Sites",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Experts_Sites_SiteID",
                schema: "dbo",
                table: "Experts",
                column: "SiteID",
                principalSchema: "dbo",
                principalTable: "Sites",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Sites_SiteID",
                schema: "dbo",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Experts_Sites_SiteID",
                schema: "dbo",
                table: "Experts");

            migrationBuilder.DropIndex(
                name: "IX_Categories_SiteID",
                schema: "dbo",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "SiteID",
                schema: "dbo",
                table: "Categories");

            migrationBuilder.AlterColumn<int>(
                name: "SiteID",
                schema: "dbo",
                table: "Experts",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Experts_Sites_SiteID",
                schema: "dbo",
                table: "Experts",
                column: "SiteID",
                principalSchema: "dbo",
                principalTable: "Sites",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
