using Microsoft.EntityFrameworkCore.Migrations;

namespace _3Nobatgir.Data.Migrations.My
{
    public partial class sitename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_dbo.Sites_SiteID",
                schema: "dbo",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_dbo.Sites_SiteKinds_SiteKindID",
                schema: "dbo",
                table: "dbo.Sites");

            migrationBuilder.DropForeignKey(
                name: "FK_SiteDictionaries_dbo.Sites_SiteID",
                schema: "dbo",
                table: "SiteDictionaries");

            migrationBuilder.DropForeignKey(
                name: "FK_SiteSettings_dbo.Sites_SiteID",
                schema: "dbo",
                table: "SiteSettings");

            migrationBuilder.DropForeignKey(
                name: "FK_SiteTimeTemplates_dbo.Sites_SiteID",
                schema: "dbo",
                table: "SiteTimeTemplates");

            migrationBuilder.DropPrimaryKey(
                name: "PK_dbo.Sites",
                schema: "dbo",
                table: "dbo.Sites");

            migrationBuilder.RenameTable(
                name: "dbo.Sites",
                schema: "dbo",
                newName: "Sites",
                newSchema: "dbo");

            migrationBuilder.RenameIndex(
                name: "IX_dbo.Sites_SiteKindID",
                schema: "dbo",
                table: "Sites",
                newName: "IX_Sites_SiteKindID");

            migrationBuilder.AddColumn<int>(
                name: "SiteID",
                schema: "dbo",
                table: "Role",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sites",
                schema: "dbo",
                table: "Sites",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_Role_SiteID",
                schema: "dbo",
                table: "Role",
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
                name: "FK_Role_Sites_SiteID",
                schema: "dbo",
                table: "Role",
                column: "SiteID",
                principalSchema: "dbo",
                principalTable: "Sites",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SiteDictionaries_Sites_SiteID",
                schema: "dbo",
                table: "SiteDictionaries",
                column: "SiteID",
                principalSchema: "dbo",
                principalTable: "Sites",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sites_SiteKinds_SiteKindID",
                schema: "dbo",
                table: "Sites",
                column: "SiteKindID",
                principalSchema: "dbo",
                principalTable: "SiteKinds",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SiteSettings_Sites_SiteID",
                schema: "dbo",
                table: "SiteSettings",
                column: "SiteID",
                principalSchema: "dbo",
                principalTable: "Sites",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SiteTimeTemplates_Sites_SiteID",
                schema: "dbo",
                table: "SiteTimeTemplates",
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
                name: "FK_Role_Sites_SiteID",
                schema: "dbo",
                table: "Role");

            migrationBuilder.DropForeignKey(
                name: "FK_SiteDictionaries_Sites_SiteID",
                schema: "dbo",
                table: "SiteDictionaries");

            migrationBuilder.DropForeignKey(
                name: "FK_Sites_SiteKinds_SiteKindID",
                schema: "dbo",
                table: "Sites");

            migrationBuilder.DropForeignKey(
                name: "FK_SiteSettings_Sites_SiteID",
                schema: "dbo",
                table: "SiteSettings");

            migrationBuilder.DropForeignKey(
                name: "FK_SiteTimeTemplates_Sites_SiteID",
                schema: "dbo",
                table: "SiteTimeTemplates");

            migrationBuilder.DropIndex(
                name: "IX_Role_SiteID",
                schema: "dbo",
                table: "Role");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sites",
                schema: "dbo",
                table: "Sites");

            migrationBuilder.DropColumn(
                name: "SiteID",
                schema: "dbo",
                table: "Role");

            migrationBuilder.RenameTable(
                name: "Sites",
                schema: "dbo",
                newName: "dbo.Sites",
                newSchema: "dbo");

            migrationBuilder.RenameIndex(
                name: "IX_Sites_SiteKindID",
                schema: "dbo",
                table: "dbo.Sites",
                newName: "IX_dbo.Sites_SiteKindID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_dbo.Sites",
                schema: "dbo",
                table: "dbo.Sites",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_dbo.Sites_SiteID",
                schema: "dbo",
                table: "Categories",
                column: "SiteID",
                principalSchema: "dbo",
                principalTable: "dbo.Sites",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_dbo.Sites_SiteKinds_SiteKindID",
                schema: "dbo",
                table: "dbo.Sites",
                column: "SiteKindID",
                principalSchema: "dbo",
                principalTable: "SiteKinds",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SiteDictionaries_dbo.Sites_SiteID",
                schema: "dbo",
                table: "SiteDictionaries",
                column: "SiteID",
                principalSchema: "dbo",
                principalTable: "dbo.Sites",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SiteSettings_dbo.Sites_SiteID",
                schema: "dbo",
                table: "SiteSettings",
                column: "SiteID",
                principalSchema: "dbo",
                principalTable: "dbo.Sites",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SiteTimeTemplates_dbo.Sites_SiteID",
                schema: "dbo",
                table: "SiteTimeTemplates",
                column: "SiteID",
                principalSchema: "dbo",
                principalTable: "dbo.Sites",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
