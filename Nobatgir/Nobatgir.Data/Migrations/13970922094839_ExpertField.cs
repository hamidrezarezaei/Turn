using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _3Nobatgir.Data.Migrations.My
{
    public partial class ExpertField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ExpertFields",
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
                    ExpertID = table.Column<int>(nullable: false),
                    FieldType = table.Column<int>(nullable: false),
                    Value = table.Column<string>(nullable: true),
                    SourceTypeID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpertFields", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ExpertFields_Experts_ExpertID",
                        column: x => x.ExpertID,
                        principalSchema: "dbo",
                        principalTable: "Experts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExpertFields_SourceTypes_SourceTypeID",
                        column: x => x.SourceTypeID,
                        principalSchema: "dbo",
                        principalTable: "SourceTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExpertFields_ExpertID",
                schema: "dbo",
                table: "ExpertFields",
                column: "ExpertID");

            migrationBuilder.CreateIndex(
                name: "IX_ExpertFields_SourceTypeID",
                schema: "dbo",
                table: "ExpertFields",
                column: "SourceTypeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExpertFields",
                schema: "dbo");
        }
    }
}
