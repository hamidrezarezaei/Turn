using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _3Nobatgir.Data.Migrations.Identity
{
    public partial class init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SiteID",
                schema: "auth",
                table: "AspNetRoles",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoles_dbo.Sites_SiteID",
                schema: "auth",
                table: "AspNetRoles",
                column: "SiteID",
                principalSchema: "dbo",
                principalTable: "dbo.Sites",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoles_dbo.Sites_SiteID",
                schema: "auth",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "SiteID",
                schema: "auth",
                table: "AspNetRoles");
        }
    }
}
