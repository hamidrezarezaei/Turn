using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _3Nobatgir.Data.Migrations.My
{
    public partial class adminmenu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RoleActions",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Acts",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ActCategories",
                schema: "dbo");

            migrationBuilder.CreateTable(
                name: "AdminMenus",
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
                    SiteKindID = table.Column<int>(nullable: false),
                    ControllerName = table.Column<string>(nullable: true),
                    ActionName = table.Column<string>(nullable: true),
                    LevelID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminMenus", x => x.ID);
                    table.ForeignKey(
                        name: "FK_AdminMenus_SiteKinds_SiteKindID",
                        column: x => x.SiteKindID,
                        principalSchema: "dbo",
                        principalTable: "SiteKinds",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdminMenus_SiteKindID",
                schema: "dbo",
                table: "AdminMenus",
                column: "SiteKindID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdminMenus",
                schema: "dbo");

            migrationBuilder.CreateTable(
                name: "ActCategories",
                schema: "dbo",
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
                    table.PrimaryKey("PK_ActCategories", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Acts",
                schema: "dbo",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ActCategoryID = table.Column<int>(nullable: false),
                    ActName = table.Column<string>(nullable: true),
                    ControllerName = table.Column<string>(nullable: true),
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
                    table.PrimaryKey("PK_Acts", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Acts_ActCategories_ActCategoryID",
                        column: x => x.ActCategoryID,
                        principalSchema: "dbo",
                        principalTable: "ActCategories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoleActions",
                schema: "dbo",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ActionID = table.Column<int>(nullable: false),
                    HasAdd = table.Column<bool>(nullable: false),
                    HasDelete = table.Column<bool>(nullable: false),
                    HasEdit = table.Column<bool>(nullable: false),
                    HasView = table.Column<bool>(nullable: false),
                    RoleID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleActions", x => x.ID);
                    table.ForeignKey(
                        name: "FK_RoleActions_Acts_ActionID",
                        column: x => x.ActionID,
                        principalSchema: "dbo",
                        principalTable: "Acts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoleActions_Role_RoleID",
                        column: x => x.RoleID,
                        principalSchema: "dbo",
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Acts_ActCategoryID",
                schema: "dbo",
                table: "Acts",
                column: "ActCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Role_SiteID",
                schema: "dbo",
                table: "Role",
                column: "SiteID");

            migrationBuilder.CreateIndex(
                name: "IX_RoleActions_ActionID",
                schema: "dbo",
                table: "RoleActions",
                column: "ActionID");

            migrationBuilder.CreateIndex(
                name: "IX_RoleActions_RoleID",
                schema: "dbo",
                table: "RoleActions",
                column: "RoleID");
        }
    }
}
