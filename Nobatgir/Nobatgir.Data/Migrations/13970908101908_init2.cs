using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _3Nobatgir.Data.Migrations.Identity
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoles_Site_SiteID",
                schema: "auth",
                table: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "SiteKindDictionary",
                schema: "auth");

            migrationBuilder.DropTable(
                name: "SiteSetting",
                schema: "auth");

            migrationBuilder.DropTable(
                name: "SiteTimeTemplate",
                schema: "auth");

            migrationBuilder.DropTable(
                name: "DictionaryTerm",
                schema: "auth");

            migrationBuilder.DropTable(
                name: "Site",
                schema: "auth");

            migrationBuilder.DropTable(
                name: "SiteKind",
                schema: "auth");

            migrationBuilder.DropIndex(
                name: "IX_AspNetRoles_SiteID",
                schema: "auth",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "SiteID",
                schema: "auth",
                table: "AspNetRoles");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SiteID",
                schema: "auth",
                table: "AspNetRoles",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "DictionaryTerm",
                schema: "auth",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Term = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DictionaryTerm", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SiteKind",
                schema: "auth",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    OrderIndex = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    UpdateDateTime = table.Column<DateTime>(nullable: false),
                    UserID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiteKind", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Site",
                schema: "auth",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Domain = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    OrderIndex = table.Column<int>(nullable: false),
                    SiteKindID = table.Column<int>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    UpdateDateTime = table.Column<DateTime>(nullable: false),
                    UserID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Site", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Site_SiteKind_SiteKindID",
                        column: x => x.SiteKindID,
                        principalSchema: "auth",
                        principalTable: "SiteKind",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SiteKindDictionary",
                schema: "auth",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DictionaryTermID = table.Column<int>(nullable: false),
                    SiteKindID = table.Column<int>(nullable: true),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiteKindDictionary", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SiteKindDictionary_DictionaryTerm_DictionaryTermID",
                        column: x => x.DictionaryTermID,
                        principalSchema: "auth",
                        principalTable: "DictionaryTerm",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SiteKindDictionary_SiteKind_SiteKindID",
                        column: x => x.SiteKindID,
                        principalSchema: "auth",
                        principalTable: "SiteKind",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SiteSetting",
                schema: "auth",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Key = table.Column<string>(nullable: true),
                    SiteID = table.Column<int>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiteSetting", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SiteSetting_Site_SiteID",
                        column: x => x.SiteID,
                        principalSchema: "auth",
                        principalTable: "Site",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SiteTimeTemplate",
                schema: "auth",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ActiveDayCount = table.Column<string>(nullable: true),
                    ActiveTime = table.Column<string>(nullable: true),
                    DeactiveDayCount = table.Column<int>(nullable: false),
                    DeactiveTime = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    OrderIndex = table.Column<int>(nullable: false),
                    SiteID = table.Column<int>(nullable: false),
                    Times = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    UpdateDateTime = table.Column<DateTime>(nullable: false),
                    UserID = table.Column<int>(nullable: false),
                    WeekDay = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiteTimeTemplate", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SiteTimeTemplate_Site_SiteID",
                        column: x => x.SiteID,
                        principalSchema: "auth",
                        principalTable: "Site",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoles_SiteID",
                schema: "auth",
                table: "AspNetRoles",
                column: "SiteID");

            migrationBuilder.CreateIndex(
                name: "IX_Site_SiteKindID",
                schema: "auth",
                table: "Site",
                column: "SiteKindID");

            migrationBuilder.CreateIndex(
                name: "IX_SiteKindDictionary_DictionaryTermID",
                schema: "auth",
                table: "SiteKindDictionary",
                column: "DictionaryTermID");

            migrationBuilder.CreateIndex(
                name: "IX_SiteKindDictionary_SiteKindID",
                schema: "auth",
                table: "SiteKindDictionary",
                column: "SiteKindID");

            migrationBuilder.CreateIndex(
                name: "IX_SiteSetting_SiteID",
                schema: "auth",
                table: "SiteSetting",
                column: "SiteID");

            migrationBuilder.CreateIndex(
                name: "IX_SiteTimeTemplate_SiteID",
                schema: "auth",
                table: "SiteTimeTemplate",
                column: "SiteID");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoles_Site_SiteID",
                schema: "auth",
                table: "AspNetRoles",
                column: "SiteID",
                principalSchema: "auth",
                principalTable: "Site",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
