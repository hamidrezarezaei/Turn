using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _3Nobatgir.Data.Migrations.Identity
{
    public partial class roletitle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                schema: "auth",
                table: "AspNetRoles",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "auth",
                table: "AspNetRoles",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "OrderIndex",
                schema: "auth",
                table: "AspNetRoles",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                schema: "auth",
                table: "AspNetRoles",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDateTime",
                schema: "auth",
                table: "AspNetRoles",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "UserID",
                schema: "auth",
                table: "AspNetRoles",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                schema: "auth",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "auth",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "OrderIndex",
                schema: "auth",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "Title",
                schema: "auth",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "UpdateDateTime",
                schema: "auth",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "UserID",
                schema: "auth",
                table: "AspNetRoles");
        }
    }
}
