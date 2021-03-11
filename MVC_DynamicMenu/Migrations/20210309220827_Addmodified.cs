using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_DynamicMenu.Migrations
{
    public partial class Addmodified : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ServiceSchedules",
                table: "ServiceSchedules");

            migrationBuilder.DropColumn(
                name: "Reference",
                table: "ServiceSchedules");

            migrationBuilder.AddColumn<int>(
                name: "ReferenceID",
                table: "ServiceSchedules",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ReferenceID",
                table: "LogSchedule",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ServiceSchedulesReferenceID",
                table: "LogSchedule",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ServiceSchedules",
                table: "ServiceSchedules",
                column: "ReferenceID");

            migrationBuilder.CreateIndex(
                name: "IX_LogSchedule_ServiceSchedulesReferenceID",
                table: "LogSchedule",
                column: "ServiceSchedulesReferenceID");

            migrationBuilder.AddForeignKey(
                name: "FK_LogSchedule_ServiceSchedules_ServiceSchedulesReferenceID",
                table: "LogSchedule",
                column: "ServiceSchedulesReferenceID",
                principalTable: "ServiceSchedules",
                principalColumn: "ReferenceID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LogSchedule_ServiceSchedules_ServiceSchedulesReferenceID",
                table: "LogSchedule");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ServiceSchedules",
                table: "ServiceSchedules");

            migrationBuilder.DropIndex(
                name: "IX_LogSchedule_ServiceSchedulesReferenceID",
                table: "LogSchedule");

            migrationBuilder.DropColumn(
                name: "ReferenceID",
                table: "ServiceSchedules");

            migrationBuilder.DropColumn(
                name: "ReferenceID",
                table: "LogSchedule");

            migrationBuilder.DropColumn(
                name: "ServiceSchedulesReferenceID",
                table: "LogSchedule");

            migrationBuilder.AddColumn<int>(
                name: "Reference",
                table: "ServiceSchedules",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ServiceSchedules",
                table: "ServiceSchedules",
                column: "Reference");
        }
    }
}
