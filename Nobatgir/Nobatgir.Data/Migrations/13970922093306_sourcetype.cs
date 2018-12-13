using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _3Nobatgir.Data.Migrations.My
{
    public partial class sourcetype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
          
            migrationBuilder.CreateTable(
                name: "SourceTypes",
                schema: "dbo",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    OrderIndex = table.Column<int>(nullable: false),
                    UserID = table.Column<int>(nullable: false),
                    UpdateDateTime = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SourceTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SourceValues",
                schema: "dbo",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    OrderIndex = table.Column<int>(nullable: false),
                    UserID = table.Column<int>(nullable: false),
                    UpdateDateTime = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    SourceTypeID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SourceValues", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SourceValues_SourceTypes_SourceTypeID",
                        column: x => x.SourceTypeID,
                        principalSchema: "dbo",
                        principalTable: "SourceTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

        
            migrationBuilder.CreateIndex(
                name: "IX_SourceValues_SourceTypeID",
                schema: "dbo",
                table: "SourceValues",
                column: "SourceTypeID");

        
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdminMenus_SiteKinds_SiteKindID",
                schema: "dbo",
                table: "AdminMenus");

            migrationBuilder.DropForeignKey(
                name: "FK_SiteKindDictionaries_SiteKinds_SiteKindID",
                schema: "dbo",
                table: "SiteKindDictionaries");

            migrationBuilder.DropForeignKey(
                name: "FK_Sites_SiteKinds_SiteKindID",
                schema: "dbo",
                table: "Sites");

            migrationBuilder.DropTable(
                name: "SourceValues",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "SourceTypes",
                schema: "dbo");

            migrationBuilder.DropIndex(
                name: "IX_Sites_SiteKindID",
                schema: "dbo",
                table: "Sites");

            migrationBuilder.DropIndex(
                name: "IX_SiteKindDictionaries_SiteKindID",
                schema: "dbo",
                table: "SiteKindDictionaries");

            migrationBuilder.DropIndex(
                name: "IX_AdminMenus_SiteKindID",
                schema: "dbo",
                table: "AdminMenus");

            migrationBuilder.AddColumn<int>(
                name: "SiteKindID1",
                schema: "dbo",
                table: "Sites",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SiteKindID1",
                schema: "dbo",
                table: "SiteKindDictionaries",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SiteKindID1",
                schema: "dbo",
                table: "AdminMenus",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sites_SiteKindID1",
                schema: "dbo",
                table: "Sites",
                column: "SiteKindID1");

            migrationBuilder.CreateIndex(
                name: "IX_SiteKindDictionaries_SiteKindID1",
                schema: "dbo",
                table: "SiteKindDictionaries",
                column: "SiteKindID1");

            migrationBuilder.CreateIndex(
                name: "IX_AdminMenus_SiteKindID1",
                schema: "dbo",
                table: "AdminMenus",
                column: "SiteKindID1");

            migrationBuilder.AddForeignKey(
                name: "FK_AdminMenus_SiteKinds_SiteKindID1",
                schema: "dbo",
                table: "AdminMenus",
                column: "SiteKindID1",
                principalSchema: "dbo",
                principalTable: "SiteKinds",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SiteKindDictionaries_SiteKinds_SiteKindID1",
                schema: "dbo",
                table: "SiteKindDictionaries",
                column: "SiteKindID1",
                principalSchema: "dbo",
                principalTable: "SiteKinds",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Sites_SiteKinds_SiteKindID1",
                schema: "dbo",
                table: "Sites",
                column: "SiteKindID1",
                principalSchema: "dbo",
                principalTable: "SiteKinds",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
