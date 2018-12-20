using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _3Nobatgir.Data.Migrations.My
{
    public partial class settingbaseclass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Key",
                schema: "dbo",
                table: "SiteSettings",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "Key",
                schema: "dbo",
                table: "SiteKindSettings",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "Key",
                schema: "dbo",
                table: "ExpertSettings",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "Key",
                schema: "dbo",
                table: "CategorySettings",
                newName: "Title");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                schema: "dbo",
                table: "SiteSettings",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "dbo",
                table: "SiteSettings",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                schema: "dbo",
                table: "SiteSettings",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrderIndex",
                schema: "dbo",
                table: "SiteSettings",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDateTime",
                schema: "dbo",
                table: "SiteSettings",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "UserID",
                schema: "dbo",
                table: "SiteSettings",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                schema: "dbo",
                table: "SiteKindSettings",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "dbo",
                table: "SiteKindSettings",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                schema: "dbo",
                table: "SiteKindSettings",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrderIndex",
                schema: "dbo",
                table: "SiteKindSettings",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDateTime",
                schema: "dbo",
                table: "SiteKindSettings",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "UserID",
                schema: "dbo",
                table: "SiteKindSettings",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                schema: "dbo",
                table: "ExpertSettings",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "dbo",
                table: "ExpertSettings",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                schema: "dbo",
                table: "ExpertSettings",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrderIndex",
                schema: "dbo",
                table: "ExpertSettings",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDateTime",
                schema: "dbo",
                table: "ExpertSettings",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "UserID",
                schema: "dbo",
                table: "ExpertSettings",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                schema: "dbo",
                table: "CategorySettings",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "dbo",
                table: "CategorySettings",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                schema: "dbo",
                table: "CategorySettings",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrderIndex",
                schema: "dbo",
                table: "CategorySettings",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDateTime",
                schema: "dbo",
                table: "CategorySettings",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "UserID",
                schema: "dbo",
                table: "CategorySettings",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                schema: "dbo",
                table: "SiteSettings");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "dbo",
                table: "SiteSettings");

            migrationBuilder.DropColumn(
                name: "Name",
                schema: "dbo",
                table: "SiteSettings");

            migrationBuilder.DropColumn(
                name: "OrderIndex",
                schema: "dbo",
                table: "SiteSettings");

            migrationBuilder.DropColumn(
                name: "UpdateDateTime",
                schema: "dbo",
                table: "SiteSettings");

            migrationBuilder.DropColumn(
                name: "UserID",
                schema: "dbo",
                table: "SiteSettings");

            migrationBuilder.DropColumn(
                name: "IsActive",
                schema: "dbo",
                table: "SiteKindSettings");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "dbo",
                table: "SiteKindSettings");

            migrationBuilder.DropColumn(
                name: "Name",
                schema: "dbo",
                table: "SiteKindSettings");

            migrationBuilder.DropColumn(
                name: "OrderIndex",
                schema: "dbo",
                table: "SiteKindSettings");

            migrationBuilder.DropColumn(
                name: "UpdateDateTime",
                schema: "dbo",
                table: "SiteKindSettings");

            migrationBuilder.DropColumn(
                name: "UserID",
                schema: "dbo",
                table: "SiteKindSettings");

            migrationBuilder.DropColumn(
                name: "IsActive",
                schema: "dbo",
                table: "ExpertSettings");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "dbo",
                table: "ExpertSettings");

            migrationBuilder.DropColumn(
                name: "Name",
                schema: "dbo",
                table: "ExpertSettings");

            migrationBuilder.DropColumn(
                name: "OrderIndex",
                schema: "dbo",
                table: "ExpertSettings");

            migrationBuilder.DropColumn(
                name: "UpdateDateTime",
                schema: "dbo",
                table: "ExpertSettings");

            migrationBuilder.DropColumn(
                name: "UserID",
                schema: "dbo",
                table: "ExpertSettings");

            migrationBuilder.DropColumn(
                name: "IsActive",
                schema: "dbo",
                table: "CategorySettings");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "dbo",
                table: "CategorySettings");

            migrationBuilder.DropColumn(
                name: "Name",
                schema: "dbo",
                table: "CategorySettings");

            migrationBuilder.DropColumn(
                name: "OrderIndex",
                schema: "dbo",
                table: "CategorySettings");

            migrationBuilder.DropColumn(
                name: "UpdateDateTime",
                schema: "dbo",
                table: "CategorySettings");

            migrationBuilder.DropColumn(
                name: "UserID",
                schema: "dbo",
                table: "CategorySettings");

            migrationBuilder.RenameColumn(
                name: "Title",
                schema: "dbo",
                table: "SiteSettings",
                newName: "Key");

            migrationBuilder.RenameColumn(
                name: "Title",
                schema: "dbo",
                table: "SiteKindSettings",
                newName: "Key");

            migrationBuilder.RenameColumn(
                name: "Title",
                schema: "dbo",
                table: "ExpertSettings",
                newName: "Key");

            migrationBuilder.RenameColumn(
                name: "Title",
                schema: "dbo",
                table: "CategorySettings",
                newName: "Key");
        }
    }
}
