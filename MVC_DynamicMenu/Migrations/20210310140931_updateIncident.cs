using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_DynamicMenu.Migrations
{
    public partial class updateIncident : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Absconding_Requiring_Missing_Persons_Report",
                table: "NewIncidentLog",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Actions",
                table: "NewIncidentLog",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Agitation_Hyperarousal",
                table: "NewIncidentLog",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Assault_Requiring_Medical_Support",
                table: "NewIncidentLog",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Attempted_Minor",
                table: "NewIncidentLog",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Attempted_Minor_Property_Damage",
                table: "NewIncidentLog",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Behaviour_or_Challenges_Attracting_Community_Concern",
                table: "NewIncidentLog",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Behaviour_or_Challenges_Attracting_Media_Attention",
                table: "NewIncidentLog",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Client_Complaint",
                table: "NewIncidentLog",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Client_Complaint_or_issue",
                table: "NewIncidentLog",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Criminal_Behaviour_Resulting_in_Police_Engagment_or_Charges",
                table: "NewIncidentLog",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Disclosure_Requireing_Mandatory_Reporting",
                table: "NewIncidentLog",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Disruption_to_Routine",
                table: "NewIncidentLog",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Inappropriate_or_Anti_Social_Client_Interaction",
                table: "NewIncidentLog",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IncidentInvolvingFamily",
                table: "NewIncidentLog",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Incident_Involving_Family",
                table: "NewIncidentLog",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Injury_Minor_Client_Injury_First_Aid_Only",
                table: "NewIncidentLog",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Non_Compliance_Refusal",
                table: "NewIncidentLog",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Non_Compliance_Task_Refusal",
                table: "NewIncidentLog",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PRNApproved",
                table: "NewIncidentLog",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PRN_Approved",
                table: "NewIncidentLog",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Who_On_Call_Contacted",
                table: "NewIncidentLog",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Absconding_Requiring_Missing_Persons_Report",
                table: "NewIncidentLog");

            migrationBuilder.DropColumn(
                name: "Actions",
                table: "NewIncidentLog");

            migrationBuilder.DropColumn(
                name: "Agitation_Hyperarousal",
                table: "NewIncidentLog");

            migrationBuilder.DropColumn(
                name: "Assault_Requiring_Medical_Support",
                table: "NewIncidentLog");

            migrationBuilder.DropColumn(
                name: "Attempted_Minor",
                table: "NewIncidentLog");

            migrationBuilder.DropColumn(
                name: "Attempted_Minor_Property_Damage",
                table: "NewIncidentLog");

            migrationBuilder.DropColumn(
                name: "Behaviour_or_Challenges_Attracting_Community_Concern",
                table: "NewIncidentLog");

            migrationBuilder.DropColumn(
                name: "Behaviour_or_Challenges_Attracting_Media_Attention",
                table: "NewIncidentLog");

            migrationBuilder.DropColumn(
                name: "Client_Complaint",
                table: "NewIncidentLog");

            migrationBuilder.DropColumn(
                name: "Client_Complaint_or_issue",
                table: "NewIncidentLog");

            migrationBuilder.DropColumn(
                name: "Criminal_Behaviour_Resulting_in_Police_Engagment_or_Charges",
                table: "NewIncidentLog");

            migrationBuilder.DropColumn(
                name: "Disclosure_Requireing_Mandatory_Reporting",
                table: "NewIncidentLog");

            migrationBuilder.DropColumn(
                name: "Disruption_to_Routine",
                table: "NewIncidentLog");

            migrationBuilder.DropColumn(
                name: "Inappropriate_or_Anti_Social_Client_Interaction",
                table: "NewIncidentLog");

            migrationBuilder.DropColumn(
                name: "IncidentInvolvingFamily",
                table: "NewIncidentLog");

            migrationBuilder.DropColumn(
                name: "Incident_Involving_Family",
                table: "NewIncidentLog");

            migrationBuilder.DropColumn(
                name: "Injury_Minor_Client_Injury_First_Aid_Only",
                table: "NewIncidentLog");

            migrationBuilder.DropColumn(
                name: "Non_Compliance_Refusal",
                table: "NewIncidentLog");

            migrationBuilder.DropColumn(
                name: "Non_Compliance_Task_Refusal",
                table: "NewIncidentLog");

            migrationBuilder.DropColumn(
                name: "PRNApproved",
                table: "NewIncidentLog");

            migrationBuilder.DropColumn(
                name: "PRN_Approved",
                table: "NewIncidentLog");

            migrationBuilder.DropColumn(
                name: "Who_On_Call_Contacted",
                table: "NewIncidentLog");
        }
    }
}
