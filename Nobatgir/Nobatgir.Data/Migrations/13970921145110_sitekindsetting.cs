using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _3Nobatgir.Data.Migrations.My
{
    public partial class sitekindsetting : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryTimeTemplates",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "SiteTimeTemplates",
                schema: "dbo");

            migrationBuilder.CreateTable(
                name: "SiteKindSettings",
                schema: "dbo",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Key = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true),
                    SiteKindID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiteKindSettings", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SiteKindSettings_SiteKinds_SiteKindID",
                        column: x => x.SiteKindID,
                        principalSchema: "dbo",
                        principalTable: "SiteKinds",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SiteKindSettings_SiteKindID",
                schema: "dbo",
                table: "SiteKindSettings",
                column: "SiteKindID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SiteKindSettings",
                schema: "dbo");

            migrationBuilder.CreateTable(
                name: "CategoryTimeTemplates",
                schema: "dbo",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ActiveDayCount = table.Column<int>(nullable: false),
                    ActiveTime = table.Column<string>(nullable: true),
                    CategoryID = table.Column<int>(nullable: false),
                    DeactiveDayCount = table.Column<int>(nullable: false),
                    DeactiveTime = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    OrderIndex = table.Column<int>(nullable: false),
                    Times = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    UpdateDateTime = table.Column<DateTime>(nullable: false),
                    UserID = table.Column<int>(nullable: false),
                    WeekDay = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryTimeTemplates", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CategoryTimeTemplates_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalSchema: "dbo",
                        principalTable: "Categories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SiteTimeTemplates",
                schema: "dbo",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ActiveDayCount = table.Column<int>(nullable: false),
                    ActiveTime = table.Column<string>(nullable: true),
                    DeactiveDayCount = table.Column<int>(nullable: false),
                    DeactiveTime = table.Column<string>(nullable: true),
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
                    table.PrimaryKey("PK_SiteTimeTemplates", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SiteTimeTemplates_Sites_SiteID",
                        column: x => x.SiteID,
                        principalSchema: "dbo",
                        principalTable: "Sites",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryTimeTemplates_CategoryID",
                schema: "dbo",
                table: "CategoryTimeTemplates",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_SiteTimeTemplates_SiteID",
                schema: "dbo",
                table: "SiteTimeTemplates",
                column: "SiteID");
        }
    }
}
