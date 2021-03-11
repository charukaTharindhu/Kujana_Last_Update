using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_DynamicMenu.Migrations
{
    public partial class AddTherapyLog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NewTherapyLog",
                columns: table => new
                {
                    ClientID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Client_Name = table.Column<string>(nullable: true),
                    Entry_date = table.Column<string>(nullable: true),
                    Hierarchy = table.Column<string>(nullable: true),
                    Mental_Duration_Time = table.Column<string>(nullable: true),
                    Mental_Before_Therapy = table.Column<string>(nullable: true),
                    Mental_After_Therapy = table.Column<string>(nullable: true),
                    Mental_Exercises = table.Column<string>(nullable: true),
                    Mental_Client_Concerns = table.Column<string>(nullable: true),
                    Mental_Status = table.Column<string>(nullable: true),
                    Physical_Duration_Time = table.Column<string>(nullable: true),
                    Physical_Before_Therapy = table.Column<string>(nullable: true),
                    Physical_After_Therapy = table.Column<string>(nullable: true),
                    Physical_Exercises = table.Column<string>(nullable: true),
                    Physical_Client_Concerns = table.Column<string>(nullable: true),
                    Physical_Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewTherapyLog", x => x.ClientID);
                });

            migrationBuilder.CreateTable(
                name: "TherapyLog",
                columns: table => new
                {
                    Reference = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Client = table.Column<string>(nullable: true),
                    Unit = table.Column<string>(nullable: true),
                    Entry_Date = table.Column<string>(nullable: true),
                    Last_Updated = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TherapyLog", x => x.Reference);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NewTherapyLog");

            migrationBuilder.DropTable(
                name: "TherapyLog");
        }
    }
}
