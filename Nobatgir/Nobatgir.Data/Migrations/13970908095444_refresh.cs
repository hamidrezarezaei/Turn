using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _3Nobatgir.Data.Migrations
{
    public partial class refresh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "ActCategories",
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
                    table.PrimaryKey("PK_ActCategories", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DictionaryTerms",
                schema: "dbo",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Term = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DictionaryTerms", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SiteKinds",
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
                    table.PrimaryKey("PK_SiteKinds", x => x.ID);
                });

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
                    ActName = table.Column<string>(nullable: true),
                    ActCategoryID = table.Column<int>(nullable: false)
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
                name: "SiteKindDictionaries",
                schema: "dbo",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DictionaryTermID = table.Column<int>(nullable: false),
                    Value = table.Column<string>(nullable: true),
                    SiteKindID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiteKindDictionaries", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SiteKindDictionaries_DictionaryTerms_DictionaryTermID",
                        column: x => x.DictionaryTermID,
                        principalSchema: "dbo",
                        principalTable: "DictionaryTerms",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SiteKindDictionaries_SiteKinds_SiteKindID",
                        column: x => x.SiteKindID,
                        principalSchema: "dbo",
                        principalTable: "SiteKinds",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sites",
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
                    Domain = table.Column<string>(nullable: true),
                    SiteKindID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sites", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Sites_SiteKinds_SiteKindID",
                        column: x => x.SiteKindID,
                        principalSchema: "dbo",
                        principalTable: "SiteKinds",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

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
                    IsDeleted = table.Column<bool>(nullable: false),
                    SiteID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Categories_Sites_SiteID",
                        column: x => x.SiteID,
                        principalSchema: "dbo",
                        principalTable: "Sites",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    NormalizedName = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    SiteID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Role_Sites_SiteID",
                        column: x => x.SiteID,
                        principalSchema: "dbo",
                        principalTable: "Sites",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SiteDictionaries",
                schema: "dbo",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DictionaryTermID = table.Column<int>(nullable: false),
                    Value = table.Column<string>(nullable: true),
                    SiteID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiteDictionaries", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SiteDictionaries_DictionaryTerms_DictionaryTermID",
                        column: x => x.DictionaryTermID,
                        principalSchema: "dbo",
                        principalTable: "DictionaryTerms",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SiteDictionaries_Sites_SiteID",
                        column: x => x.SiteID,
                        principalSchema: "dbo",
                        principalTable: "Sites",
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

            migrationBuilder.CreateTable(
                name: "Experts",
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
                    CategoryID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experts", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Experts_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalSchema: "dbo",
                        principalTable: "Categories",
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
                    RoleID = table.Column<int>(nullable: false),
                    HasView = table.Column<bool>(nullable: false),
                    HasAdd = table.Column<bool>(nullable: false),
                    HasEdit = table.Column<bool>(nullable: false),
                    HasDelete = table.Column<bool>(nullable: false)
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

            migrationBuilder.CreateIndex(
                name: "IX_Acts_ActCategoryID",
                schema: "dbo",
                table: "Acts",
                column: "ActCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_SiteID",
                schema: "dbo",
                table: "Categories",
                column: "SiteID");

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
                name: "IX_Experts_CategoryID",
                schema: "dbo",
                table: "Experts",
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

            migrationBuilder.CreateIndex(
                name: "IX_SiteDictionaries_DictionaryTermID",
                schema: "dbo",
                table: "SiteDictionaries",
                column: "DictionaryTermID");

            migrationBuilder.CreateIndex(
                name: "IX_SiteDictionaries_SiteID",
                schema: "dbo",
                table: "SiteDictionaries",
                column: "SiteID");

            migrationBuilder.CreateIndex(
                name: "IX_SiteKindDictionaries_DictionaryTermID",
                schema: "dbo",
                table: "SiteKindDictionaries",
                column: "DictionaryTermID");

            migrationBuilder.CreateIndex(
                name: "IX_SiteKindDictionaries_SiteKindID",
                schema: "dbo",
                table: "SiteKindDictionaries",
                column: "SiteKindID");

            migrationBuilder.CreateIndex(
                name: "IX_Sites_SiteKindID",
                schema: "dbo",
                table: "Sites",
                column: "SiteKindID");

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
                name: "RoleActions",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "SiteDictionaries",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "SiteKindDictionaries",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "SiteSettings",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "SiteTimeTemplates",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Experts",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Acts",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Role",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "DictionaryTerms",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Categories",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ActCategories",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Sites",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "SiteKinds",
                schema: "dbo");
        }
    }
}
