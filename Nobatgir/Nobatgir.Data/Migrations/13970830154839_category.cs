using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Nobatgir.Data.Migrations
{
    public partial class category : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Settings",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "TimeTemplates",
                schema: "dbo");

            migrationBuilder.CreateTable(
                name: "Categories",
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
                    table.PrimaryKey("PK_Categories", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ExpertSettings",
                schema: "dbo",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Key = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true),
                    ExpertID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpertSettings", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ExpertSettings_Experts_ExpertID",
                        column: x => x.ExpertID,
                        principalSchema: "dbo",
                        principalTable: "Experts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExpertTimeTemplates",
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
                    WeekDay = table.Column<int>(nullable: false),
                    Times = table.Column<string>(nullable: true),
                    ActiveDayCount = table.Column<string>(nullable: true),
                    ActiveTime = table.Column<string>(nullable: true),
                    DeactiveDayCount = table.Column<int>(nullable: false),
                    DeactiveTime = table.Column<int>(nullable: false),
                    ExpertID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpertTimeTemplates", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ExpertTimeTemplates_Experts_ExpertID",
                        column: x => x.ExpertID,
                        principalSchema: "dbo",
                        principalTable: "Experts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SiteSettings",
                schema: "dbo",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Key = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true),
                    SiteID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiteSettings", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SiteSettings_Sites_SiteID",
                        column: x => x.SiteID,
                        principalSchema: "dbo",
                        principalTable: "Sites",
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
                    Name = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    OrderIndex = table.Column<int>(nullable: false),
                    UserID = table.Column<int>(nullable: false),
                    UpdateDateTime = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    WeekDay = table.Column<int>(nullable: false),
                    Times = table.Column<string>(nullable: true),
                    ActiveDayCount = table.Column<string>(nullable: true),
                    ActiveTime = table.Column<string>(nullable: true),
                    DeactiveDayCount = table.Column<int>(nullable: false),
                    DeactiveTime = table.Column<int>(nullable: false),
                    SiteID = table.Column<int>(nullable: false)
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

            migrationBuilder.CreateTable(
                name: "CategorySettings",
                schema: "dbo",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Key = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true),
                    CategoryID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategorySettings", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CategorySettings_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalSchema: "dbo",
                        principalTable: "Categories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CategoryTimeTemplates",
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
                    WeekDay = table.Column<int>(nullable: false),
                    Times = table.Column<string>(nullable: true),
                    ActiveDayCount = table.Column<string>(nullable: true),
                    ActiveTime = table.Column<string>(nullable: true),
                    DeactiveDayCount = table.Column<int>(nullable: false),
                    DeactiveTime = table.Column<int>(nullable: false),
                    CategoryID = table.Column<int>(nullable: false)
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

            migrationBuilder.CreateIndex(
                name: "IX_CategorySettings_CategoryID",
                schema: "dbo",
                table: "CategorySettings",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryTimeTemplates_CategoryID",
                schema: "dbo",
                table: "CategoryTimeTemplates",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_ExpertSettings_ExpertID",
                schema: "dbo",
                table: "ExpertSettings",
                column: "ExpertID");

            migrationBuilder.CreateIndex(
                name: "IX_ExpertTimeTemplates_ExpertID",
                schema: "dbo",
                table: "ExpertTimeTemplates",
                column: "ExpertID");

            migrationBuilder.CreateIndex(
                name: "IX_SiteSettings_SiteID",
                schema: "dbo",
                table: "SiteSettings",
                column: "SiteID");

            migrationBuilder.CreateIndex(
                name: "IX_SiteTimeTemplates_SiteID",
                schema: "dbo",
                table: "SiteTimeTemplates",
                column: "SiteID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategorySettings",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CategoryTimeTemplates",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ExpertSettings",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ExpertTimeTemplates",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "SiteSettings",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "SiteTimeTemplates",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Categories",
                schema: "dbo");

            migrationBuilder.CreateTable(
                name: "Settings",
                schema: "dbo",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ExpertID = table.Column<int>(nullable: true),
                    Key = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Settings_Experts_ExpertID",
                        column: x => x.ExpertID,
                        principalSchema: "dbo",
                        principalTable: "Experts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TimeTemplates",
                schema: "dbo",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ActiveDayCount = table.Column<string>(nullable: true),
                    ActiveTime = table.Column<string>(nullable: true),
                    DeactiveDayCount = table.Column<int>(nullable: false),
                    DeactiveTime = table.Column<int>(nullable: false),
                    ExpertID = table.Column<int>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    OrderIndex = table.Column<int>(nullable: false),
                    Place = table.Column<string>(nullable: true),
                    Times = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    UpdateDateTime = table.Column<DateTime>(nullable: false),
                    UserID = table.Column<int>(nullable: false),
                    WeekDay = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeTemplates", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TimeTemplates_Experts_ExpertID",
                        column: x => x.ExpertID,
                        principalSchema: "dbo",
                        principalTable: "Experts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Settings_ExpertID",
                schema: "dbo",
                table: "Settings",
                column: "ExpertID");

            migrationBuilder.CreateIndex(
                name: "IX_TimeTemplates_ExpertID",
                schema: "dbo",
                table: "TimeTemplates",
                column: "ExpertID");
        }
    }
}
