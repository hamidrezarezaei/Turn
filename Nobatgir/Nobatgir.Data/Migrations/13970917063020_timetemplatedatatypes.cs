using Microsoft.EntityFrameworkCore.Migrations;

namespace _3Nobatgir.Data.Migrations.My
{
    public partial class timetemplatedatatypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DeactiveTime",
                schema: "dbo",
                table: "SiteTimeTemplates",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ActiveDayCount",
                schema: "dbo",
                table: "SiteTimeTemplates",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeactiveTime",
                schema: "dbo",
                table: "ExpertTimeTemplates",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ActiveDayCount",
                schema: "dbo",
                table: "ExpertTimeTemplates",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeactiveTime",
                schema: "dbo",
                table: "CategoryTimeTemplates",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ActiveDayCount",
                schema: "dbo",
                table: "CategoryTimeTemplates",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "DeactiveTime",
                schema: "dbo",
                table: "SiteTimeTemplates",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ActiveDayCount",
                schema: "dbo",
                table: "SiteTimeTemplates",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "DeactiveTime",
                schema: "dbo",
                table: "ExpertTimeTemplates",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ActiveDayCount",
                schema: "dbo",
                table: "ExpertTimeTemplates",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "DeactiveTime",
                schema: "dbo",
                table: "CategoryTimeTemplates",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ActiveDayCount",
                schema: "dbo",
                table: "CategoryTimeTemplates",
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}
