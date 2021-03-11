using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_DynamicMenu.Migrations
{
    public partial class addFk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CareTeams",
                columns: table => new
                {
                    CareTeameID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sub_Program = table.Column<string>(nullable: true),
                    Group = table.Column<string>(nullable: true),
                    Referal_Date = table.Column<string>(nullable: true),
                    Referal_source = table.Column<string>(nullable: true),
                    Referal_name = table.Column<string>(nullable: true),
                    Agency_name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    PatientID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CareTeams", x => x.CareTeameID);
                    table.ForeignKey(
                        name: "FK_CareTeams_Patient_PatientID",
                        column: x => x.PatientID,
                        principalTable: "Patient",
                        principalColumn: "PatientID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Case_Worker",
                columns: table => new
                {
                    WorkerID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateAllocated = table.Column<string>(nullable: true),
                    DateDeallocated = table.Column<string>(nullable: true),
                    KeyWorker = table.Column<string>(nullable: true),
                    PatientID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Case_Worker", x => x.WorkerID);
                    table.ForeignKey(
                        name: "FK_Case_Worker_Patient_PatientID",
                        column: x => x.PatientID,
                        principalTable: "Patient",
                        principalColumn: "PatientID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Commencement_Issuse",
                columns: table => new
                {
                    CommencementID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Program_Details_and_Support_needs = table.Column<string>(nullable: true),
                    Education_Training = table.Column<string>(nullable: true),
                    Family_Community_Support = table.Column<string>(nullable: true),
                    Employeement = table.Column<string>(nullable: true),
                    Living_Skills = table.Column<string>(nullable: true),
                    Housing_Accomadation = table.Column<string>(nullable: true),
                    Aduocacy = table.Column<string>(nullable: true),
                    anger = table.Column<string>(nullable: true),
                    Arts_cultural_development = table.Column<string>(nullable: true),
                    Counselling = table.Column<string>(nullable: true),
                    Discrimination_including_ = table.Column<string>(nullable: true),
                    Comments = table.Column<string>(nullable: true),
                    PatientID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commencement_Issuse", x => x.CommencementID);
                    table.ForeignKey(
                        name: "FK_Commencement_Issuse_Patient_PatientID",
                        column: x => x.PatientID,
                        principalTable: "Patient",
                        principalColumn: "PatientID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Files",
                columns: table => new
                {
                    FilesID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Files", x => x.FilesID);
                    table.ForeignKey(
                        name: "FK_Files_Patient_PatientID",
                        column: x => x.PatientID,
                        principalTable: "Patient",
                        principalColumn: "PatientID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Housing_Register_Application",
                columns: table => new
                {
                    ApplicationID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AolicationType = table.Column<string>(nullable: true),
                    priority_catogory = table.Column<string>(nullable: true),
                    Date_Submited = table.Column<string>(nullable: true),
                    Location_Submited = table.Column<string>(nullable: true),
                    Application_number = table.Column<string>(nullable: true),
                    PatientID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Housing_Register_Application", x => x.ApplicationID);
                    table.ForeignKey(
                        name: "FK_Housing_Register_Application_Patient_PatientID",
                        column: x => x.PatientID,
                        principalTable: "Patient",
                        principalColumn: "PatientID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Patient_Contact",
                columns: table => new
                {
                    ContactID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Relationship = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Disclose_Address = table.Column<string>(nullable: true),
                    Line1 = table.Column<string>(nullable: true),
                    Line2 = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    Type_of_housing = table.Column<string>(nullable: true),
                    Start_Date = table.Column<string>(nullable: true),
                    Security = table.Column<string>(nullable: true),
                    LivingWith = table.Column<string>(nullable: true),
                    Comment = table.Column<string>(nullable: true),
                    emargencyPhone = table.Column<int>(nullable: false),
                    Can_text = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    PatientID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patient_Contact", x => x.ContactID);
                    table.ForeignKey(
                        name: "FK_Patient_Contact_Patient_PatientID",
                        column: x => x.PatientID,
                        principalTable: "Patient",
                        principalColumn: "PatientID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Patient_Helth",
                columns: table => new
                {
                    PatientHelthID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dissabilities_none = table.Column<string>(nullable: true),
                    Hearing_inmpairment = table.Column<string>(nullable: true),
                    Vission_impa = table.Column<string>(nullable: true),
                    Interlrctual_disability = table.Column<string>(nullable: true),
                    Physical_disability = table.Column<string>(nullable: true),
                    Acquried_brain_injury = table.Column<string>(nullable: true),
                    Suspected_ABI = table.Column<string>(nullable: true),
                    Down_Syndrome = table.Column<string>(nullable: true),
                    Other = table.Column<string>(nullable: true),
                    Unknown = table.Column<string>(nullable: true),
                    Allergies = table.Column<string>(nullable: true),
                    Skin_condition = table.Column<string>(nullable: true),
                    Diabetes = table.Column<string>(nullable: true),
                    Chronic_pain = table.Column<string>(nullable: true),
                    Epilepsy = table.Column<string>(nullable: true),
                    Obesity = table.Column<string>(nullable: true),
                    Infectious_Disease = table.Column<string>(nullable: true),
                    Repiratory = table.Column<string>(nullable: true),
                    Cardiovscular = table.Column<string>(nullable: true),
                    Medicare_number = table.Column<string>(nullable: true),
                    Suffix = table.Column<string>(nullable: true),
                    Exp = table.Column<string>(nullable: true),
                    PatientID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patient_Helth", x => x.PatientHelthID);
                    table.ForeignKey(
                        name: "FK_Patient_Helth_Patient_PatientID",
                        column: x => x.PatientID,
                        principalTable: "Patient",
                        principalColumn: "PatientID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Patient_Info",
                columns: table => new
                {
                    Patient_InfoID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NDIS_Number = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<string>(nullable: true),
                    Office = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    COB_Comment = table.Column<string>(nullable: true),
                    Indegenous_status = table.Column<string>(nullable: true),
                    Other_Cultural_Issues = table.Column<string>(nullable: true),
                    Language_spoken_at_home = table.Column<string>(nullable: true),
                    Interpreted_needed = table.Column<string>(nullable: true),
                    Comments = table.Column<string>(nullable: true),
                    Primary_income_source = table.Column<string>(nullable: true),
                    Effective_date = table.Column<string>(nullable: true),
                    CeterLink_Number = table.Column<string>(nullable: true),
                    PatientID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patient_Info", x => x.Patient_InfoID);
                    table.ForeignKey(
                        name: "FK_Patient_Info_Patient_PatientID",
                        column: x => x.PatientID,
                        principalTable: "Patient",
                        principalColumn: "PatientID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Programs",
                columns: table => new
                {
                    ProgramID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Program = table.Column<string>(nullable: true),
                    Commenced = table.Column<string>(nullable: true),
                    DateOfExit = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    Pause = table.Column<string>(nullable: true),
                    Resume = table.Column<string>(nullable: true),
                    Setting = table.Column<string>(nullable: true),
                    PatientID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Programs", x => x.ProgramID);
                    table.ForeignKey(
                        name: "FK_Programs_Patient_PatientID",
                        column: x => x.PatientID,
                        principalTable: "Patient",
                        principalColumn: "PatientID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Summerising",
                columns: table => new
                {
                    SummerisingID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrivacyAndConsent_Date_Signed = table.Column<string>(nullable: true),
                    PrivacyAndConsent_Reason = table.Column<string>(nullable: true),
                    PrivacyAndConsent_Date = table.Column<string>(nullable: true),
                    RightAndResponsibilities_DateExplained = table.Column<string>(nullable: true),
                    RightAndResponsibilities_Date = table.Column<string>(nullable: true),
                    RightAndResponsibilities_Reason = table.Column<string>(nullable: true),
                    ExitInterviewConsent_ConsentAtExite = table.Column<string>(nullable: true),
                    ExitInterviewConsent_Date = table.Column<string>(nullable: true),
                    ExitInterviewConsent_Comment = table.Column<string>(nullable: true),
                    Complaints_dateExplained = table.Column<string>(nullable: true),
                    Complaints_Date = table.Column<string>(nullable: true),
                    Complaints_Reason = table.Column<string>(nullable: true),
                    MedicalConsent_MedicalConsent = table.Column<string>(nullable: true),
                    MedicalConsent_Date = table.Column<string>(nullable: true),
                    MedicalConsent_Consent = table.Column<string>(nullable: true),
                    InformationSharingWithThirdParties_informationSharingWithThirdParties = table.Column<string>(nullable: true),
                    InformationSharingWithThirdParties_Date = table.Column<string>(nullable: true),
                    InformationSharingWithThirdParties_ConsentToShareInformation = table.Column<string>(nullable: true),
                    ourWayOfWorkingOutComes_DateCompleted = table.Column<string>(nullable: true),
                    Primary_model_of_service_while_Involved_with_program_selection = table.Column<string>(nullable: true),
                    Primary_model_of_service_while_Involved_with_program_Comment = table.Column<string>(nullable: true),
                    Participants_level_of_Engagement_In_this_Program_sellection = table.Column<string>(nullable: true),
                    Participants_level_of_Engagement_In_this_Program_Comment = table.Column<string>(nullable: true),
                    View_of_self_Sufficient_at_Commencement = table.Column<string>(nullable: true),
                    View_of_self_Worse = table.Column<string>(nullable: true),
                    View_of_self_NoChange = table.Column<string>(nullable: true),
                    View_of_self_MinimalImprovement = table.Column<string>(nullable: true),
                    View_of_self_ModerateImprovement = table.Column<string>(nullable: true),
                    View_of_self_SubstantialImprovement = table.Column<string>(nullable: true),
                    View_of_self_Comments = table.Column<string>(nullable: true),
                    Connection_to_family_and_Significant_people_Sufficient_at_Commencement = table.Column<string>(nullable: true),
                    Connection_to_family_and_Significant_people_Worse = table.Column<string>(nullable: true),
                    Connection_to_family_and_Significant_people_NoChange = table.Column<string>(nullable: true),
                    Connection_to_family_and_Significant_people_MinimalImprovement = table.Column<string>(nullable: true),
                    Connection_to_family_and_Significant_people_ModerateImprovement = table.Column<string>(nullable: true),
                    Connection_to_family_and_Significant_people_SubstantialImprovement = table.Column<string>(nullable: true),
                    Connection_to_family_and_Significant_people_View_of_self_Comments = table.Column<string>(nullable: true),
                    View_of_future_Sufficient_at_Commencement = table.Column<string>(nullable: true),
                    View_of_future_Worse = table.Column<string>(nullable: true),
                    View_of_future_NoChange = table.Column<string>(nullable: true),
                    View_of_future_MinimalImprovement = table.Column<string>(nullable: true),
                    View_of_future_ModerateImprovement = table.Column<string>(nullable: true),
                    View_of_future_SubstantialImprovement = table.Column<string>(nullable: true),
                    View_of_future_Comments = table.Column<string>(nullable: true),
                    Test_question_Sufficient_at_Commencement = table.Column<string>(nullable: true),
                    Test_question_Worse = table.Column<string>(nullable: true),
                    Test_question_NoChange = table.Column<string>(nullable: true),
                    Test_question_MinimalImprovement = table.Column<string>(nullable: true),
                    Test_question_ModerateImprovement = table.Column<string>(nullable: true),
                    Test_question_SubstantialImprovement = table.Column<string>(nullable: true),
                    Test_question_Comments = table.Column<string>(nullable: true),
                    Date_of_exit = table.Column<string>(nullable: true),
                    Reason_of_exit_Selection = table.Column<string>(nullable: true),
                    Reason_of_exit_Comment = table.Column<string>(nullable: true),
                    Goals_Achived_at_exit_Selection = table.Column<string>(nullable: true),
                    Goals_Achived_at_exit_Comment = table.Column<string>(nullable: true),
                    PatientID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Summerising", x => x.SummerisingID);
                    table.ForeignKey(
                        name: "FK_Summerising_Patient_PatientID",
                        column: x => x.PatientID,
                        principalTable: "Patient",
                        principalColumn: "PatientID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CareTeams_PatientID",
                table: "CareTeams",
                column: "PatientID");

            migrationBuilder.CreateIndex(
                name: "IX_Case_Worker_PatientID",
                table: "Case_Worker",
                column: "PatientID");

            migrationBuilder.CreateIndex(
                name: "IX_Commencement_Issuse_PatientID",
                table: "Commencement_Issuse",
                column: "PatientID");

            migrationBuilder.CreateIndex(
                name: "IX_Files_PatientID",
                table: "Files",
                column: "PatientID");

            migrationBuilder.CreateIndex(
                name: "IX_Housing_Register_Application_PatientID",
                table: "Housing_Register_Application",
                column: "PatientID");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_Contact_PatientID",
                table: "Patient_Contact",
                column: "PatientID");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_Helth_PatientID",
                table: "Patient_Helth",
                column: "PatientID");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_Info_PatientID",
                table: "Patient_Info",
                column: "PatientID");

            migrationBuilder.CreateIndex(
                name: "IX_Programs_PatientID",
                table: "Programs",
                column: "PatientID");

            migrationBuilder.CreateIndex(
                name: "IX_Summerising_PatientID",
                table: "Summerising",
                column: "PatientID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CareTeams");

            migrationBuilder.DropTable(
                name: "Case_Worker");

            migrationBuilder.DropTable(
                name: "Commencement_Issuse");

            migrationBuilder.DropTable(
                name: "Files");

            migrationBuilder.DropTable(
                name: "Housing_Register_Application");

            migrationBuilder.DropTable(
                name: "Patient_Contact");

            migrationBuilder.DropTable(
                name: "Patient_Helth");

            migrationBuilder.DropTable(
                name: "Patient_Info");

            migrationBuilder.DropTable(
                name: "Programs");

            migrationBuilder.DropTable(
                name: "Summerising");
        }
    }
}
