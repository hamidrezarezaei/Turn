using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _3Nobatgir.Data.Migrations.My
{
    public partial class turn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {


            migrationBuilder.CreateTable(
                name: "Turns",
                schema: "dbo",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    ExpertID = table.Column<int>(nullable: false),
                    TurnDate = table.Column<DateTime>(nullable: false),
                    Time = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    RegDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turns", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Turns_Experts_ExpertID",
                        column: x => x.ExpertID,
                        principalSchema: "dbo",
                        principalTable: "Experts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });


            migrationBuilder.CreateIndex(
                name: "IX_Turns_ExpertID",
                schema: "dbo",
                table: "Turns",
                column: "ExpertID");


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdminMenus_SiteKinds_SiteKindID1",
                schema: "dbo",
                table: "AdminMenus");

            migrationBuilder.DropForeignKey(
                name: "FK_SiteKindDictionaries_SiteKinds_SiteKindID1",
                schema: "dbo",
                table: "SiteKindDictionaries");

            migrationBuilder.DropForeignKey(
                name: "FK_Sites_SiteKinds_SiteKindID1",
                schema: "dbo",
                table: "Sites");

            migrationBuilder.DropTable(
                name: "Turns",
                schema: "dbo");

            migrationBuilder.DropIndex(
                name: "IX_Sites_SiteKindID1",
                schema: "dbo",
                table: "Sites");

            migrationBuilder.DropIndex(
                name: "IX_SiteKindDictionaries_SiteKindID1",
                schema: "dbo",
                table: "SiteKindDictionaries");

            migrationBuilder.DropIndex(
                name: "IX_AdminMenus_SiteKindID1",
                schema: "dbo",
                table: "AdminMenus");

            migrationBuilder.DropColumn(
                name: "SiteKindID1",
                schema: "dbo",
                table: "Sites");

            migrationBuilder.DropColumn(
                name: "SiteKindID1",
                schema: "dbo",
                table: "SiteKindDictionaries");

            migrationBuilder.DropColumn(
                name: "SiteKindID1",
                schema: "dbo",
                table: "AdminMenus");

            migrationBuilder.CreateIndex(
                name: "IX_Sites_SiteKindID",
                schema: "dbo",
                table: "Sites",
                column: "SiteKindID");

            migrationBuilder.CreateIndex(
                name: "IX_SiteKindDictionaries_SiteKindID",
                schema: "dbo",
                table: "SiteKindDictionaries",
                column: "SiteKindID");

            migrationBuilder.CreateIndex(
                name: "IX_AdminMenus_SiteKindID",
                schema: "dbo",
                table: "AdminMenus",
                column: "SiteKindID");

            migrationBuilder.AddForeignKey(
                name: "FK_AdminMenus_SiteKinds_SiteKindID",
                schema: "dbo",
                table: "AdminMenus",
                column: "SiteKindID",
                principalSchema: "dbo",
                principalTable: "SiteKinds",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SiteKindDictionaries_SiteKinds_SiteKindID",
                schema: "dbo",
                table: "SiteKindDictionaries",
                column: "SiteKindID",
                principalSchema: "dbo",
                principalTable: "SiteKinds",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sites_SiteKinds_SiteKindID",
                schema: "dbo",
                table: "Sites",
                column: "SiteKindID",
                principalSchema: "dbo",
                principalTable: "SiteKinds",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
