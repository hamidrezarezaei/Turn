using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _3Nobatgir.Data.Migrations.My
{
    public partial class turndetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TurnDetails",
                schema: "dbo",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TurnID = table.Column<Guid>(nullable: false),
                    ExpertFieldID = table.Column<int>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TurnDetails", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TurnDetails_ExpertFields_ExpertFieldID",
                        column: x => x.ExpertFieldID,
                        principalSchema: "dbo",
                        principalTable: "ExpertFields",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TurnDetails_ExpertFieldID",
                schema: "dbo",
                table: "TurnDetails",
                column: "ExpertFieldID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TurnDetails",
                schema: "dbo");
        }
    }
}
