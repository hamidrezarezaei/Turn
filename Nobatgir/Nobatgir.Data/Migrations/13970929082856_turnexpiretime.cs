using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _3Nobatgir.Data.Migrations.My
{
    public partial class turnexpiretime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdminMenus_SiteKinds_SiteKindID",
                schema: "dbo",
                table: "AdminMenus");

            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Sites_SiteID",
                schema: "dbo",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_CategorySettings_Categories_CategoryID",
                schema: "dbo",
                table: "CategorySettings");

            migrationBuilder.DropForeignKey(
                name: "FK_ExpertFields_Experts_ExpertID",
                schema: "dbo",
                table: "ExpertFields");

            migrationBuilder.DropForeignKey(
                name: "FK_Experts_Categories_CategoryID",
                schema: "dbo",
                table: "Experts");

            migrationBuilder.DropForeignKey(
                name: "FK_ExpertSettings_Experts_ExpertID",
                schema: "dbo",
                table: "ExpertSettings");

            migrationBuilder.DropForeignKey(
                name: "FK_ExpertTimeTemplates_Experts_ExpertID",
                schema: "dbo",
                table: "ExpertTimeTemplates");

            migrationBuilder.DropForeignKey(
                name: "FK_SiteDictionaries_DictionaryTerms_DictionaryTermID",
                schema: "dbo",
                table: "SiteDictionaries");

            migrationBuilder.DropForeignKey(
                name: "FK_SiteDictionaries_Sites_SiteID",
                schema: "dbo",
                table: "SiteDictionaries");

            migrationBuilder.DropForeignKey(
                name: "FK_SiteKindDictionaries_DictionaryTerms_DictionaryTermID",
                schema: "dbo",
                table: "SiteKindDictionaries");

            migrationBuilder.DropForeignKey(
                name: "FK_SiteKindDictionaries_SiteKinds_SiteKindID",
                schema: "dbo",
                table: "SiteKindDictionaries");

            migrationBuilder.DropForeignKey(
                name: "FK_SiteKindSettings_SiteKinds_SiteKindID",
                schema: "dbo",
                table: "SiteKindSettings");

            migrationBuilder.DropForeignKey(
                name: "FK_Sites_SiteKinds_SiteKindID",
                schema: "dbo",
                table: "Sites");

            migrationBuilder.DropForeignKey(
                name: "FK_SiteSettings_Sites_SiteID",
                schema: "dbo",
                table: "SiteSettings");

            migrationBuilder.DropForeignKey(
                name: "FK_SourceTypes_Experts_ExpertID",
                schema: "dbo",
                table: "SourceTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_SourceValues_SourceTypes_SourceTypeID",
                schema: "dbo",
                table: "SourceValues");

            migrationBuilder.DropForeignKey(
                name: "FK_TurnDetails_ExpertFields_ExpertFieldID",
                schema: "dbo",
                table: "TurnDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Turns_Experts_ExpertID",
                schema: "dbo",
                table: "Turns");

            migrationBuilder.AddColumn<DateTime>(
                name: "ExpireTime",
                schema: "dbo",
                table: "Turns",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_TurnDetails_TurnID",
                schema: "dbo",
                table: "TurnDetails",
                column: "TurnID");

            migrationBuilder.AddForeignKey(
                name: "FK_AdminMenus_SiteKinds_SiteKindID",
                schema: "dbo",
                table: "AdminMenus",
                column: "SiteKindID",
                principalSchema: "dbo",
                principalTable: "SiteKinds",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Sites_SiteID",
                schema: "dbo",
                table: "Categories",
                column: "SiteID",
                principalSchema: "dbo",
                principalTable: "Sites",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CategorySettings_Categories_CategoryID",
                schema: "dbo",
                table: "CategorySettings",
                column: "CategoryID",
                principalSchema: "dbo",
                principalTable: "Categories",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ExpertFields_Experts_ExpertID",
                schema: "dbo",
                table: "ExpertFields",
                column: "ExpertID",
                principalSchema: "dbo",
                principalTable: "Experts",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Experts_Categories_CategoryID",
                schema: "dbo",
                table: "Experts",
                column: "CategoryID",
                principalSchema: "dbo",
                principalTable: "Categories",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ExpertSettings_Experts_ExpertID",
                schema: "dbo",
                table: "ExpertSettings",
                column: "ExpertID",
                principalSchema: "dbo",
                principalTable: "Experts",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ExpertTimeTemplates_Experts_ExpertID",
                schema: "dbo",
                table: "ExpertTimeTemplates",
                column: "ExpertID",
                principalSchema: "dbo",
                principalTable: "Experts",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SiteDictionaries_DictionaryTerms_DictionaryTermID",
                schema: "dbo",
                table: "SiteDictionaries",
                column: "DictionaryTermID",
                principalSchema: "dbo",
                principalTable: "DictionaryTerms",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SiteDictionaries_Sites_SiteID",
                schema: "dbo",
                table: "SiteDictionaries",
                column: "SiteID",
                principalSchema: "dbo",
                principalTable: "Sites",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SiteKindDictionaries_DictionaryTerms_DictionaryTermID",
                schema: "dbo",
                table: "SiteKindDictionaries",
                column: "DictionaryTermID",
                principalSchema: "dbo",
                principalTable: "DictionaryTerms",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SiteKindDictionaries_SiteKinds_SiteKindID",
                schema: "dbo",
                table: "SiteKindDictionaries",
                column: "SiteKindID",
                principalSchema: "dbo",
                principalTable: "SiteKinds",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SiteKindSettings_SiteKinds_SiteKindID",
                schema: "dbo",
                table: "SiteKindSettings",
                column: "SiteKindID",
                principalSchema: "dbo",
                principalTable: "SiteKinds",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Sites_SiteKinds_SiteKindID",
                schema: "dbo",
                table: "Sites",
                column: "SiteKindID",
                principalSchema: "dbo",
                principalTable: "SiteKinds",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SiteSettings_Sites_SiteID",
                schema: "dbo",
                table: "SiteSettings",
                column: "SiteID",
                principalSchema: "dbo",
                principalTable: "Sites",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SourceTypes_Experts_ExpertID",
                schema: "dbo",
                table: "SourceTypes",
                column: "ExpertID",
                principalSchema: "dbo",
                principalTable: "Experts",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SourceValues_SourceTypes_SourceTypeID",
                schema: "dbo",
                table: "SourceValues",
                column: "SourceTypeID",
                principalSchema: "dbo",
                principalTable: "SourceTypes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TurnDetails_ExpertFields_ExpertFieldID",
                schema: "dbo",
                table: "TurnDetails",
                column: "ExpertFieldID",
                principalSchema: "dbo",
                principalTable: "ExpertFields",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TurnDetails_Turns_TurnID",
                schema: "dbo",
                table: "TurnDetails",
                column: "TurnID",
                principalSchema: "dbo",
                principalTable: "Turns",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Turns_Experts_ExpertID",
                schema: "dbo",
                table: "Turns",
                column: "ExpertID",
                principalSchema: "dbo",
                principalTable: "Experts",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdminMenus_SiteKinds_SiteKindID",
                schema: "dbo",
                table: "AdminMenus");

            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Sites_SiteID",
                schema: "dbo",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_CategorySettings_Categories_CategoryID",
                schema: "dbo",
                table: "CategorySettings");

            migrationBuilder.DropForeignKey(
                name: "FK_ExpertFields_Experts_ExpertID",
                schema: "dbo",
                table: "ExpertFields");

            migrationBuilder.DropForeignKey(
                name: "FK_Experts_Categories_CategoryID",
                schema: "dbo",
                table: "Experts");

            migrationBuilder.DropForeignKey(
                name: "FK_ExpertSettings_Experts_ExpertID",
                schema: "dbo",
                table: "ExpertSettings");

            migrationBuilder.DropForeignKey(
                name: "FK_ExpertTimeTemplates_Experts_ExpertID",
                schema: "dbo",
                table: "ExpertTimeTemplates");

            migrationBuilder.DropForeignKey(
                name: "FK_SiteDictionaries_DictionaryTerms_DictionaryTermID",
                schema: "dbo",
                table: "SiteDictionaries");

            migrationBuilder.DropForeignKey(
                name: "FK_SiteDictionaries_Sites_SiteID",
                schema: "dbo",
                table: "SiteDictionaries");

            migrationBuilder.DropForeignKey(
                name: "FK_SiteKindDictionaries_DictionaryTerms_DictionaryTermID",
                schema: "dbo",
                table: "SiteKindDictionaries");

            migrationBuilder.DropForeignKey(
                name: "FK_SiteKindDictionaries_SiteKinds_SiteKindID",
                schema: "dbo",
                table: "SiteKindDictionaries");

            migrationBuilder.DropForeignKey(
                name: "FK_SiteKindSettings_SiteKinds_SiteKindID",
                schema: "dbo",
                table: "SiteKindSettings");

            migrationBuilder.DropForeignKey(
                name: "FK_Sites_SiteKinds_SiteKindID",
                schema: "dbo",
                table: "Sites");

            migrationBuilder.DropForeignKey(
                name: "FK_SiteSettings_Sites_SiteID",
                schema: "dbo",
                table: "SiteSettings");

            migrationBuilder.DropForeignKey(
                name: "FK_SourceTypes_Experts_ExpertID",
                schema: "dbo",
                table: "SourceTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_SourceValues_SourceTypes_SourceTypeID",
                schema: "dbo",
                table: "SourceValues");

            migrationBuilder.DropForeignKey(
                name: "FK_TurnDetails_ExpertFields_ExpertFieldID",
                schema: "dbo",
                table: "TurnDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_TurnDetails_Turns_TurnID",
                schema: "dbo",
                table: "TurnDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Turns_Experts_ExpertID",
                schema: "dbo",
                table: "Turns");

            migrationBuilder.DropIndex(
                name: "IX_TurnDetails_TurnID",
                schema: "dbo",
                table: "TurnDetails");

            migrationBuilder.DropColumn(
                name: "ExpireTime",
                schema: "dbo",
                table: "Turns");

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
                name: "FK_Categories_Sites_SiteID",
                schema: "dbo",
                table: "Categories",
                column: "SiteID",
                principalSchema: "dbo",
                principalTable: "Sites",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategorySettings_Categories_CategoryID",
                schema: "dbo",
                table: "CategorySettings",
                column: "CategoryID",
                principalSchema: "dbo",
                principalTable: "Categories",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExpertFields_Experts_ExpertID",
                schema: "dbo",
                table: "ExpertFields",
                column: "ExpertID",
                principalSchema: "dbo",
                principalTable: "Experts",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Experts_Categories_CategoryID",
                schema: "dbo",
                table: "Experts",
                column: "CategoryID",
                principalSchema: "dbo",
                principalTable: "Categories",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExpertSettings_Experts_ExpertID",
                schema: "dbo",
                table: "ExpertSettings",
                column: "ExpertID",
                principalSchema: "dbo",
                principalTable: "Experts",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExpertTimeTemplates_Experts_ExpertID",
                schema: "dbo",
                table: "ExpertTimeTemplates",
                column: "ExpertID",
                principalSchema: "dbo",
                principalTable: "Experts",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SiteDictionaries_DictionaryTerms_DictionaryTermID",
                schema: "dbo",
                table: "SiteDictionaries",
                column: "DictionaryTermID",
                principalSchema: "dbo",
                principalTable: "DictionaryTerms",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SiteDictionaries_Sites_SiteID",
                schema: "dbo",
                table: "SiteDictionaries",
                column: "SiteID",
                principalSchema: "dbo",
                principalTable: "Sites",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SiteKindDictionaries_DictionaryTerms_DictionaryTermID",
                schema: "dbo",
                table: "SiteKindDictionaries",
                column: "DictionaryTermID",
                principalSchema: "dbo",
                principalTable: "DictionaryTerms",
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
                name: "FK_SiteKindSettings_SiteKinds_SiteKindID",
                schema: "dbo",
                table: "SiteKindSettings",
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

            migrationBuilder.AddForeignKey(
                name: "FK_SiteSettings_Sites_SiteID",
                schema: "dbo",
                table: "SiteSettings",
                column: "SiteID",
                principalSchema: "dbo",
                principalTable: "Sites",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SourceTypes_Experts_ExpertID",
                schema: "dbo",
                table: "SourceTypes",
                column: "ExpertID",
                principalSchema: "dbo",
                principalTable: "Experts",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SourceValues_SourceTypes_SourceTypeID",
                schema: "dbo",
                table: "SourceValues",
                column: "SourceTypeID",
                principalSchema: "dbo",
                principalTable: "SourceTypes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TurnDetails_ExpertFields_ExpertFieldID",
                schema: "dbo",
                table: "TurnDetails",
                column: "ExpertFieldID",
                principalSchema: "dbo",
                principalTable: "ExpertFields",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Turns_Experts_ExpertID",
                schema: "dbo",
                table: "Turns",
                column: "ExpertID",
                principalSchema: "dbo",
                principalTable: "Experts",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
