using Microsoft.EntityFrameworkCore.Migrations;

namespace Nobatgir.Data.Migrations
{
    public partial class renameact : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Acts_ActCategories_ActionCategoryID",
                schema: "dbo",
                table: "Acts");

            migrationBuilder.RenameColumn(
                name: "ActionName",
                schema: "dbo",
                table: "Acts",
                newName: "ActName");

            migrationBuilder.RenameColumn(
                name: "ActionCategoryID",
                schema: "dbo",
                table: "Acts",
                newName: "ActCategoryID");

            migrationBuilder.RenameIndex(
                name: "IX_Acts_ActionCategoryID",
                schema: "dbo",
                table: "Acts",
                newName: "IX_Acts_ActCategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Acts_ActCategories_ActCategoryID",
                schema: "dbo",
                table: "Acts",
                column: "ActCategoryID",
                principalSchema: "dbo",
                principalTable: "ActCategories",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Acts_ActCategories_ActCategoryID",
                schema: "dbo",
                table: "Acts");

            migrationBuilder.RenameColumn(
                name: "ActName",
                schema: "dbo",
                table: "Acts",
                newName: "ActionName");

            migrationBuilder.RenameColumn(
                name: "ActCategoryID",
                schema: "dbo",
                table: "Acts",
                newName: "ActionCategoryID");

            migrationBuilder.RenameIndex(
                name: "IX_Acts_ActCategoryID",
                schema: "dbo",
                table: "Acts",
                newName: "IX_Acts_ActionCategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Acts_ActCategories_ActionCategoryID",
                schema: "dbo",
                table: "Acts",
                column: "ActionCategoryID",
                principalSchema: "dbo",
                principalTable: "ActCategories",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
