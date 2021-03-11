using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_DynamicMenu.Migrations
{
    public partial class Add : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NewServiceLog");

            migrationBuilder.CreateTable(
                name: "LogSchedule",
                columns: table => new
                {
                    Reference = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Client_name = table.Column<string>(nullable: true),
                    Scheduled_start_date = table.Column<string>(nullable: true),
                    Scheduled_start_time = table.Column<string>(nullable: true),
                    Scheduled_finish_date = table.Column<string>(nullable: true),
                    Scheduled_finish_time = table.Column<string>(nullable: true),
                    Actual_start_date = table.Column<string>(nullable: true),
                    Actual_start_time = table.Column<string>(nullable: true),
                    Actual_finish_date = table.Column<string>(nullable: true),
                    Actual_finish_time = table.Column<string>(nullable: true),
                    Activity_category = table.Column<string>(nullable: true),
                    Activity = table.Column<string>(nullable: true),
                    Persons_attending = table.Column<string>(nullable: true),
                    Specific_activity_purpose = table.Column<string>(nullable: true),
                    Describe_outcome = table.Column<string>(nullable: true),
                    Issues_and_followup_requried = table.Column<string>(nullable: true),
                    Service_and_billing_note = table.Column<string>(nullable: true),
                    Staff = table.Column<string>(nullable: true),
                    Start_time = table.Column<string>(nullable: true),
                    Finish_time = table.Column<string>(nullable: true),
                    Service = table.Column<string>(nullable: true),
                    Service_Provider = table.Column<string>(nullable: true),
                    Hirarchy_Name = table.Column<string>(nullable: true),
                    Support_Item = table.Column<string>(nullable: true),
                    Ratio = table.Column<string>(nullable: true),
                    Biller_Type = table.Column<string>(nullable: true),
                    Qty = table.Column<string>(nullable: true),
                    Unit_Price = table.Column<string>(nullable: true),
                    Unit = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogSchedule", x => x.Reference);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LogSchedule");

            migrationBuilder.CreateTable(
                name: "NewServiceLog",
                columns: table => new
                {
                    Reference = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Activity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Activity_category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Actual_finish_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Actual_finish_time = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Actual_start_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Actual_start_time = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Client_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Describe_outcome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Finish_time = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Issues_and_followup_requried = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Persons_attending = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Scheduled_finish_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Scheduled_finish_time = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Scheduled_start_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Scheduled_start_time = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Service_and_billing_note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Specific_activity_purpose = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Staff = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Start_time = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewServiceLog", x => x.Reference);
                });
        }
    }
}
