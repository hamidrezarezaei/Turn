using Microsoft.EntityFrameworkCore.Migrations;

namespace _3Nobatgir.Data.Migrations.Identity
{
    public partial class deletesiteid1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        { 

            migrationBuilder.DropColumn(
                name: "SiteID",
                schema: "dbo",
                table: "AspNetRoles");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SiteID",
                schema: "dbo",
                table: "AspNetRoles",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoles_SiteID",
                schema: "dbo",
                table: "AspNetRoles",
                column: "SiteID");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoles_Sites_SiteID",
                schema: "dbo",
                table: "AspNetRoles",
                column: "SiteID",
                principalSchema: "dbo",
                principalTable: "Sites",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
