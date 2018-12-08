using Microsoft.EntityFrameworkCore.Migrations;

namespace _3Nobatgir.Data.Migrations.Identity
{
    public partial class createusersiteid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "auth");

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

            migrationBuilder.AddColumn<int>(
                name: "SiteID",
                schema: "auth",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SiteID",
                schema: "auth",
                table: "AspNetRoles",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SiteID",
                schema: "auth",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "SiteID",
                schema: "auth",
                table: "AspNetRoles");

            migrationBuilder.EnsureSchema(
                name: "dbo");

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
        }
    }
}
