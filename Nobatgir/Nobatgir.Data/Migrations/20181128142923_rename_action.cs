using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Nobatgir.Data.Migrations
{
    public partial class rename_action : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoleActions_Actions_ActionID",
                schema: "dbo",
                table: "RoleActions");

            migrationBuilder.DropTable(
                name: "Actions",
                schema: "dbo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ActionCategories",
                schema: "dbo",
                table: "ActionCategories");

            migrationBuilder.RenameTable(
                name: "ActionCategories",
                schema: "dbo",
                newName: "ActCategories",
                newSchema: "dbo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ActCategories",
                schema: "dbo",
                table: "ActCategories",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "Acts",
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
                    ControllerName = table.Column<string>(nullable: true),
                    ActionName = table.Column<string>(nullable: true),
                    ActionCategoryID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Acts", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Acts_ActCategories_ActionCategoryID",
                        column: x => x.ActionCategoryID,
                        principalSchema: "dbo",
                        principalTable: "ActCategories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Acts_ActionCategoryID",
                schema: "dbo",
                table: "Acts",
                column: "ActionCategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_RoleActions_Acts_ActionID",
                schema: "dbo",
                table: "RoleActions",
                column: "ActionID",
                principalSchema: "dbo",
                principalTable: "Acts",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoleActions_Acts_ActionID",
                schema: "dbo",
                table: "RoleActions");

            migrationBuilder.DropTable(
                name: "Acts",
                schema: "dbo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ActCategories",
                schema: "dbo",
                table: "ActCategories");

            migrationBuilder.RenameTable(
                name: "ActCategories",
                schema: "dbo",
                newName: "ActionCategories",
                newSchema: "dbo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ActionCategories",
                schema: "dbo",
                table: "ActionCategories",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "Actions",
                schema: "dbo",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ActCategoryID = table.Column<int>(nullable: false),
                    ActionName = table.Column<string>(nullable: true),
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
                    table.PrimaryKey("PK_Actions", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Actions_ActionCategories_ActCategoryID",
                        column: x => x.ActCategoryID,
                        principalSchema: "dbo",
                        principalTable: "ActionCategories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Actions_ActCategoryID",
                schema: "dbo",
                table: "Actions",
                column: "ActCategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_RoleActions_Actions_ActionID",
                schema: "dbo",
                table: "RoleActions",
                column: "ActionID",
                principalSchema: "dbo",
                principalTable: "Actions",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
