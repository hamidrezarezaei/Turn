using Microsoft.EntityFrameworkCore.Migrations;

namespace _3Nobatgir.Data.Migrations.Identity
{
    public partial class correctuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           
          
          
            migrationBuilder.RenameTable(
                name: "AspNetUserTokens",
                schema: "auth",
                newName: "AspNetUserTokens",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "AspNetUsers",
                schema: "auth",
                newName: "AspNetUsers",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "AspNetUserRoles",
                schema: "auth",
                newName: "AspNetUserRoles",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "AspNetUserLogins",
                schema: "auth",
                newName: "AspNetUserLogins",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "AspNetUserClaims",
                schema: "auth",
                newName: "AspNetUserClaims",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "AspNetRoles",
                schema: "auth",
                newName: "AspNetRoles",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "AspNetRoleClaims",
                schema: "auth",
                newName: "AspNetRoleClaims",
                newSchema: "dbo");

            //migrationBuilder.AddColumn<int>(
            //    name: "SiteID1",
            //    schema: "dbo",
            //    table: "AspNetUsers",
            //    nullable: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_AspNetUsers_SiteID1",
            //    schema: "dbo",
            //    table: "AspNetUsers",
            //    column: "SiteID1");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_AspNetUsers_Sites_SiteID1",
            //    schema: "dbo",
            //    table: "AspNetUsers",
            //    column: "SiteID1",
            //    principalSchema: "dbo",
            //    principalTable: "Sites",
            //    principalColumn: "ID",
            //    onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Sites_SiteID1",
                schema: "dbo",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_SiteID1",
                schema: "dbo",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "SiteID1",
                schema: "dbo",
                table: "AspNetUsers");

            migrationBuilder.EnsureSchema(
                name: "auth");

            migrationBuilder.RenameTable(
                name: "SiteTimeTemplate",
                schema: "dbo",
                newName: "SiteTimeTemplate",
                newSchema: "auth");

            migrationBuilder.RenameTable(
                name: "SiteSetting",
                schema: "dbo",
                newName: "SiteSetting",
                newSchema: "auth");

            migrationBuilder.RenameTable(
                name: "SiteKindDictionary",
                schema: "dbo",
                newName: "SiteKindDictionary",
                newSchema: "auth");

            migrationBuilder.RenameTable(
                name: "SiteKind",
                schema: "dbo",
                newName: "SiteKind",
                newSchema: "auth");

            migrationBuilder.RenameTable(
                name: "DictionaryTerm",
                schema: "dbo",
                newName: "DictionaryTerm",
                newSchema: "auth");

            migrationBuilder.RenameTable(
                name: "AspNetUserTokens",
                schema: "dbo",
                newName: "AspNetUserTokens",
                newSchema: "auth");

            migrationBuilder.RenameTable(
                name: "AspNetUsers",
                schema: "dbo",
                newName: "AspNetUsers",
                newSchema: "auth");

            migrationBuilder.RenameTable(
                name: "AspNetUserRoles",
                schema: "dbo",
                newName: "AspNetUserRoles",
                newSchema: "auth");

            migrationBuilder.RenameTable(
                name: "AspNetUserLogins",
                schema: "dbo",
                newName: "AspNetUserLogins",
                newSchema: "auth");

            migrationBuilder.RenameTable(
                name: "AspNetUserClaims",
                schema: "dbo",
                newName: "AspNetUserClaims",
                newSchema: "auth");

            migrationBuilder.RenameTable(
                name: "AspNetRoles",
                schema: "dbo",
                newName: "AspNetRoles",
                newSchema: "auth");

            migrationBuilder.RenameTable(
                name: "AspNetRoleClaims",
                schema: "dbo",
                newName: "AspNetRoleClaims",
                newSchema: "auth");
        }
    }
}
