using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_DynamicMenu.Migrations
{
    public partial class AddAllTb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ActiveLogMain",
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
                    table.PrimaryKey("PK_ActiveLogMain", x => x.Reference);
                });

            migrationBuilder.CreateTable(
                name: "AddNewFoodAndFluid",
                columns: table => new
                {
                    ClientID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Client_Name = table.Column<string>(nullable: true),
                    Start_date = table.Column<string>(nullable: true),
                    End_date = table.Column<string>(nullable: true),
                    Breakfast = table.Column<string>(nullable: true),
                    Lunch = table.Column<string>(nullable: true),
                    Diner = table.Column<string>(nullable: true),
                    Additional_Food = table.Column<string>(nullable: true),
                    Breakfast_Fluid = table.Column<string>(nullable: true),
                    Lunch_Fluid = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    Diner_Fluid = table.Column<string>(nullable: true),
                    Toal_Calories = table.Column<string>(nullable: true),
                    Staf_Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddNewFoodAndFluid", x => x.ClientID);
                });

            migrationBuilder.CreateTable(
                name: "AddNewRestrictivePraticeRecord",
                columns: table => new
                {
                    ClientID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Client = table.Column<string>(nullable: true),
                    EntryDate = table.Column<string>(nullable: true),
                    Hierarchy = table.Column<string>(nullable: true),
                    NDIS_practice_number = table.Column<string>(nullable: true),
                    Date_restrictive_practice_used = table.Column<string>(nullable: true),
                    Time_commenced = table.Column<string>(nullable: true),
                    Time_ceased = table.Column<string>(nullable: true),
                    Duration_minutes = table.Column<string>(nullable: true),
                    What_type_of_restrictive_practice_used = table.Column<string>(nullable: true),
                    Brief_description_of_the_practice = table.Column<string>(nullable: true),
                    Routine_or_PRN = table.Column<string>(nullable: true),
                    Number_of_time_used = table.Column<string>(nullable: true),
                    Incident_report_refference_number = table.Column<string>(nullable: true),
                    Circumstances_before_using_restrictive_practice = table.Column<string>(nullable: true),
                    Related_behaviour_of_Concem = table.Column<string>(nullable: true),
                    If_other_please_specify = table.Column<string>(nullable: true),
                    PlaneID = table.Column<string>(nullable: true),
                    If_no_planeID_select_the_relevent_BSP_status = table.Column<string>(nullable: true),
                    Authorised_status = table.Column<string>(nullable: true),
                    Medication = table.Column<string>(nullable: true),
                    Dosage = table.Column<string>(nullable: true),
                    Unite_of_Measurment = table.Column<string>(nullable: true),
                    Frequency = table.Column<string>(nullable: true),
                    StaffName = table.Column<string>(nullable: true),
                    Signature = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddNewRestrictivePraticeRecord", x => x.ClientID);
                });

            migrationBuilder.CreateTable(
                name: "AddNewShiftLogAM",
                columns: table => new
                {
                    ClientID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Client = table.Column<string>(nullable: true),
                    EntryDate = table.Column<string>(nullable: true),
                    Hierarchy = table.Column<string>(nullable: true),
                    Authorised_substance_use_protocol_adhered_to = table.Column<string>(nullable: true),
                    Behavior_Emotional_issues = table.Column<string>(nullable: true),
                    Chore_plane_followed = table.Column<string>(nullable: true),
                    Daily_planed_adheared_to = table.Column<string>(nullable: true),
                    Education_has_the_client_Attended_school_today = table.Column<string>(nullable: true),
                    Excercise_plane_followed = table.Column<string>(nullable: true),
                    Incident_log_copleted = table.Column<string>(nullable: true),
                    Medication_Administrated_as_Prescribed = table.Column<string>(nullable: true),
                    Menu_Diet_plane_folowed = table.Column<string>(nullable: true),
                    Personal_core_routine_Followed = table.Column<string>(nullable: true),
                    PRN_administrered = table.Column<string>(nullable: true),
                    Rainforcement_points_achivevede = table.Column<string>(nullable: true),
                    Wake_up_routine_followed = table.Column<string>(nullable: true),
                    Progress_note = table.Column<string>(nullable: true),
                    Staff_member_name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddNewShiftLogAM", x => x.ClientID);
                });

            migrationBuilder.CreateTable(
                name: "AddNewShiftLogNight",
                columns: table => new
                {
                    ClientID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Client = table.Column<string>(nullable: true),
                    EntryDate = table.Column<string>(nullable: true),
                    Hierarchy = table.Column<string>(nullable: true),
                    Authorised_substance_use_protocol_adhered_to = table.Column<string>(nullable: true),
                    Behavior_Emotional_issues = table.Column<string>(nullable: true),
                    Chore_plane_followed = table.Column<string>(nullable: true),
                    Daily_planed_adheared_to = table.Column<string>(nullable: true),
                    Education_has_the_client_Attended_school_today = table.Column<string>(nullable: true),
                    Excercise_plane_followed = table.Column<string>(nullable: true),
                    Incident_log_copleted = table.Column<string>(nullable: true),
                    Medication_Administrated_as_Prescribed = table.Column<string>(nullable: true),
                    Menu_Diet_plane_folowed = table.Column<string>(nullable: true),
                    Personal_core_routine_Followed = table.Column<string>(nullable: true),
                    PRN_administrered = table.Column<string>(nullable: true),
                    Rainforcement_points_achivevede = table.Column<string>(nullable: true),
                    Wake_up_routine_followed = table.Column<string>(nullable: true),
                    Progress_note = table.Column<string>(nullable: true),
                    Staff_member_name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddNewShiftLogNight", x => x.ClientID);
                });

            migrationBuilder.CreateTable(
                name: "AddNewShiftLogPM",
                columns: table => new
                {
                    ClientID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Client = table.Column<string>(nullable: true),
                    EntryDate = table.Column<string>(nullable: true),
                    Hierarchy = table.Column<string>(nullable: true),
                    Authorised_substance_use_protocol_adhered_to = table.Column<string>(nullable: true),
                    Behavior_Emotional_issues = table.Column<string>(nullable: true),
                    Chore_plane_followed = table.Column<string>(nullable: true),
                    Daily_planed_adheared_to = table.Column<string>(nullable: true),
                    Education_has_the_client_Attended_school_today = table.Column<string>(nullable: true),
                    Excercise_plane_followed = table.Column<string>(nullable: true),
                    Incident_log_copleted = table.Column<string>(nullable: true),
                    Medication_Administrated_as_Prescribed = table.Column<string>(nullable: true),
                    Menu_Diet_plane_folowed = table.Column<string>(nullable: true),
                    Personal_core_routine_Followed = table.Column<string>(nullable: true),
                    PRN_administrered = table.Column<string>(nullable: true),
                    Rainforcement_points_achivevede = table.Column<string>(nullable: true),
                    Wake_up_routine_followed = table.Column<string>(nullable: true),
                    Progress_note = table.Column<string>(nullable: true),
                    Staff_member_name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddNewShiftLogPM", x => x.ClientID);
                });

            migrationBuilder.CreateTable(
                name: "AddNewSLESProgress",
                columns: table => new
                {
                    ClientID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Client = table.Column<string>(nullable: true),
                    EntryDate = table.Column<string>(nullable: true),
                    Hierarchy = table.Column<string>(nullable: true),
                    Date = table.Column<string>(nullable: true),
                    TypeOfContact = table.Column<string>(nullable: true),
                    Activity = table.Column<string>(nullable: true),
                    AnyBarrierssIdentified = table.Column<string>(nullable: true),
                    If_yes_list_barriers_identifieed = table.Column<string>(nullable: true),
                    Step_taken_to_Address_beriers = table.Column<string>(nullable: true),
                    Duration = table.Column<string>(nullable: true),
                    StaffName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddNewSLESProgress", x => x.ClientID);
                });

            migrationBuilder.CreateTable(
                name: "AddNewStaffMeeting",
                columns: table => new
                {
                    Reference = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Client_Name = table.Column<string>(nullable: true),
                    Entry_Date = table.Column<string>(nullable: true),
                    Hierarchy = table.Column<string>(nullable: true),
                    Date_and_Time = table.Column<string>(nullable: true),
                    Time = table.Column<string>(nullable: true),
                    Next_Meeting_Date_and_Time = table.Column<string>(nullable: true),
                    Next_Meeting_Time = table.Column<string>(nullable: true),
                    Attendence = table.Column<string>(nullable: true),
                    Apologies = table.Column<string>(nullable: true),
                    Chairperson = table.Column<string>(nullable: true),
                    Minute_Taker = table.Column<string>(nullable: true),
                    Standing_agenda_Items = table.Column<string>(nullable: true),
                    Actions_From_Previous_minutes = table.Column<string>(nullable: true),
                    Good_news_stories = table.Column<string>(nullable: true),
                    NDIS_Goals = table.Column<string>(nullable: true),
                    New_Activities_or_experience_to_share = table.Column<string>(nullable: true),
                    Health_concerms = table.Column<string>(nullable: true),
                    Upcomin_Appointments = table.Column<string>(nullable: true),
                    Incident_Reports = table.Column<string>(nullable: true),
                    Changes_In_Behaviour = table.Column<string>(nullable: true),
                    Training_Oppotunities = table.Column<string>(nullable: true),
                    CIARS_Recording = table.Column<string>(nullable: true),
                    Any_WH_and_S_issues_to_reported = table.Column<string>(nullable: true),
                    House_mainteance = table.Column<string>(nullable: true),
                    The_policy_reviewed_during_the_meeting_and_discussion = table.Column<string>(nullable: true),
                    Staff_Discussion = table.Column<string>(nullable: true),
                    What_does_the_team_needs_to_follow_up = table.Column<string>(nullable: true),
                    What_deos_the_coordinator_needs_to_follow_up = table.Column<string>(nullable: true),
                    Staff_Member_Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddNewStaffMeeting", x => x.Reference);
                });

            migrationBuilder.CreateTable(
                name: "AddNewSupportCoordination",
                columns: table => new
                {
                    ClientID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Client_name = table.Column<string>(nullable: true),
                    EntryDate = table.Column<string>(nullable: true),
                    Heirarchy = table.Column<string>(nullable: true),
                    Date = table.Column<string>(nullable: true),
                    Time = table.Column<string>(nullable: true),
                    Type_of_support_coordination_activity = table.Column<string>(nullable: true),
                    ContactType = table.Column<string>(nullable: true),
                    ServiceType = table.Column<string>(nullable: true),
                    Billable_non_billable_time = table.Column<string>(nullable: true),
                    Purpose = table.Column<string>(nullable: true),
                    Outcome = table.Column<string>(nullable: true),
                    FollowUp = table.Column<string>(nullable: true),
                    Duration = table.Column<string>(nullable: true),
                    StaffName = table.Column<string>(nullable: true),
                    StaffSignature = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddNewSupportCoordination", x => x.ClientID);
                });

            migrationBuilder.CreateTable(
                name: "ApprovedTb",
                columns: table => new
                {
                    Reference = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Client_name = table.Column<string>(nullable: true),
                    Start_date = table.Column<string>(nullable: true),
                    End_date = table.Column<string>(nullable: true),
                    Service = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApprovedTb", x => x.Reference);
                });

            migrationBuilder.CreateTable(
                name: "BehaviorLog",
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
                    table.PrimaryKey("PK_BehaviorLog", x => x.Reference);
                });

            migrationBuilder.CreateTable(
                name: "BudgetAgreement",
                columns: table => new
                {
                    Reference = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NDIS_ID = table.Column<int>(nullable: false),
                    Client = table.Column<string>(nullable: true),
                    Date_of_birth = table.Column<string>(nullable: true),
                    Start_Date = table.Column<string>(nullable: true),
                    End_Date = table.Column<string>(nullable: true),
                    Actions = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BudgetAgreement", x => x.Reference);
                });

            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    ClientID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Clients = table.Column<string>(nullable: true),
                    EntryDate = table.Column<string>(nullable: true),
                    Hierarchy = table.Column<string>(nullable: true),
                    AM_Transport = table.Column<string>(nullable: true),
                    PM_Transport = table.Column<string>(nullable: true),
                    ActivityStartDate = table.Column<string>(nullable: true),
                    TimeFrom = table.Column<string>(nullable: true),
                    ActivityEndDate = table.Column<string>(nullable: true),
                    TimeTo = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    PersonAttending = table.Column<string>(nullable: true),
                    ActivityScheduled = table.Column<string>(nullable: true),
                    ClientAttendend = table.Column<string>(nullable: true),
                    PrimaryPurposeOfActivity = table.Column<string>(nullable: true),
                    Activity_ModifyEachOrganisations = table.Column<string>(nullable: true),
                    SpecifyActivityPurpos = table.Column<string>(nullable: true),
                    DescribeOutcomes = table.Column<string>(nullable: true),
                    IssuesAndFollowupRequired = table.Column<string>(nullable: true),
                    Attachments = table.Column<string>(nullable: true),
                    StaffMemberName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.ClientID);
                });

            migrationBuilder.CreateTable(
                name: "EmergencyFireEvacutionDrill",
                columns: table => new
                {
                    Reference = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Unit = table.Column<string>(nullable: true),
                    Entry_Date = table.Column<string>(nullable: true),
                    Date = table.Column<string>(nullable: true),
                    Time = table.Column<string>(nullable: true),
                    Work_Unit = table.Column<string>(nullable: true),
                    Location_of_fire = table.Column<string>(nullable: true),
                    Participants_present_at_the_fire_drill = table.Column<string>(nullable: true),
                    Describe_the_evacuation = table.Column<string>(nullable: true),
                    What_worked = table.Column<string>(nullable: true),
                    Where_any_changes_made_to_how_you_evacute = table.Column<string>(nullable: true),
                    Where_there_any_risks_identified = table.Column<string>(nullable: true),
                    Staff_name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmergencyFireEvacutionDrill", x => x.Reference);
                });

            migrationBuilder.CreateTable(
                name: "FireDrill",
                columns: table => new
                {
                    Reference = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Unit = table.Column<string>(nullable: true),
                    Entry_Date = table.Column<string>(nullable: true),
                    Last_Updated = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FireDrill", x => x.Reference);
                });

            migrationBuilder.CreateTable(
                name: "FoodAndFluid",
                columns: table => new
                {
                    ClientID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Client_Name = table.Column<string>(nullable: true),
                    Pending_Plans = table.Column<string>(nullable: true),
                    Approved_Plane = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodAndFluid", x => x.ClientID);
                });

            migrationBuilder.CreateTable(
                name: "Fortnighttly",
                columns: table => new
                {
                    Reference = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Unit = table.Column<string>(nullable: true),
                    Entry_Date = table.Column<string>(nullable: true),
                    Last_Updated = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fortnighttly", x => x.Reference);
                });

            migrationBuilder.CreateTable(
                name: "IncidentLog",
                columns: table => new
                {
                    ClientID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Client = table.Column<string>(nullable: true),
                    Unit = table.Column<string>(nullable: true),
                    EntryDate = table.Column<string>(nullable: true),
                    LastUpdate = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncidentLog", x => x.ClientID);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceTb",
                columns: table => new
                {
                    Reference = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cliam_number = table.Column<int>(nullable: false),
                    Client_name = table.Column<string>(nullable: true),
                    Start_date = table.Column<string>(nullable: true),
                    End_date = table.Column<string>(nullable: true),
                    Service = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceTb", x => x.Reference);
                });

            migrationBuilder.CreateTable(
                name: "Medication",
                columns: table => new
                {
                    MedicationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Client = table.Column<string>(nullable: true),
                    StartDate = table.Column<string>(nullable: true),
                    EndDate = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Dosage = table.Column<string>(nullable: true),
                    route = table.Column<string>(nullable: true),
                    timing = table.Column<string>(nullable: true),
                    frequency = table.Column<string>(nullable: true),
                    prescribed_by = table.Column<string>(nullable: true),
                    status = table.Column<string>(nullable: true),
                    clientId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medication", x => x.MedicationId);
                });

            migrationBuilder.CreateTable(
                name: "Medication_main",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientId = table.Column<int>(nullable: false),
                    FullName = table.Column<string>(nullable: true),
                    ApprovedPlans = table.Column<int>(nullable: false),
                    PendingPlans = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medication_main", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    MenuId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Menu = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.MenuId);
                });

            migrationBuilder.CreateTable(
                name: "NewBehaviorLog",
                columns: table => new
                {
                    BehaviorID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Client = table.Column<string>(nullable: true),
                    EntryDate = table.Column<string>(nullable: true),
                    Hierarchy = table.Column<string>(nullable: true),
                    Genaral_Illness = table.Column<string>(nullable: true),
                    Menstruation = table.Column<string>(nullable: true),
                    weight_EnterOnecAMonth = table.Column<string>(nullable: true),
                    Abnormal_perceptions = table.Column<string>(nullable: true),
                    Alcohol_Substance_Solvent_Use = table.Column<string>(nullable: true),
                    Antisocial_Behavior = table.Column<string>(nullable: true),
                    Anxiety = table.Column<string>(nullable: true),
                    Binging_Purging_Refusal_To_Eat = table.Column<string>(nullable: true),
                    Communication_Issues = table.Column<string>(nullable: true),
                    Difficulties_With_Refusal_To_Engage_In_Learning = table.Column<string>(nullable: true),
                    Difficulties_With_Refusal_To_Engage_independence_Skills = table.Column<string>(nullable: true),
                    Difficulties_With_Refusal_To_Maintain_Personal_Self_Carfe = table.Column<string>(nullable: true),
                    Difference_Self_Regulating_Emotions = table.Column<string>(nullable: true),
                    Distress_Worring_Crying = table.Column<string>(nullable: true),
                    Distortion_Memory_Loss = table.Column<string>(nullable: true),
                    Fears_and_Phobias = table.Column<string>(nullable: true),
                    Impulsive_Behavior_Targeting_Property_of_Others = table.Column<string>(nullable: true),
                    Intention_Lack_of_Concentration = table.Column<string>(nullable: true),
                    Indiscriminate_Disclosures = table.Column<string>(nullable: true),
                    Loss_Of_Interest_in_Activities = table.Column<string>(nullable: true),
                    Mimicking_Other_Behavior = table.Column<string>(nullable: true),
                    Obsersions_Or_Compulsions = table.Column<string>(nullable: true),
                    Odd_and_Or_Bizarre_Behavior = table.Column<string>(nullable: true),
                    Oppositional_Defiant_Behaviour = table.Column<string>(nullable: true),
                    Overactive_Behavior = table.Column<string>(nullable: true),
                    Physical_Aggression = table.Column<string>(nullable: true),
                    Problems_With_Peers_Staff_Family = table.Column<string>(nullable: true),
                    Self_Criticism = table.Column<string>(nullable: true),
                    Self_Injury_Evidence_of = table.Column<string>(nullable: true),
                    Self_Injury_Thoughts_of = table.Column<string>(nullable: true),
                    Sexualised_Behavior = table.Column<string>(nullable: true),
                    Signs_Of_Disclosure_Of_Hearing_Voices = table.Column<string>(nullable: true),
                    Sleep_Problems_Chronic_Fatigue_Bed_Wetting = table.Column<string>(nullable: true),
                    Somatising = table.Column<string>(nullable: true),
                    Verbal_Aggression = table.Column<string>(nullable: true),
                    Withdrawal_From_Others = table.Column<string>(nullable: true),
                    Active_Listening = table.Column<string>(nullable: true),
                    Anger_Management = table.Column<string>(nullable: true),
                    Being_Respectful = table.Column<string>(nullable: true),
                    Being_Safe = table.Column<string>(nullable: true),
                    Conflict_Management = table.Column<string>(nullable: true),
                    Cooperation = table.Column<string>(nullable: true),
                    Effective_Communication = table.Column<string>(nullable: true),
                    Following_Directions = table.Column<string>(nullable: true),
                    Helping_Others = table.Column<string>(nullable: true),
                    Increasing_Acceptance_and_Tolerance_of_Diverse_Group = table.Column<string>(nullable: true),
                    Listening = table.Column<string>(nullable: true),
                    Participation = table.Column<string>(nullable: true),
                    Patience = table.Column<string>(nullable: true),
                    Peer_Pesistance_Skills = table.Column<string>(nullable: true),
                    Politenss_and_Manners = table.Column<string>(nullable: true),
                    Positive_Iteraction = table.Column<string>(nullable: true),
                    Praising_others_and_Refraining_From_Nesative_Comments = table.Column<string>(nullable: true),
                    Recognising_Understanding_point_of_view_of_others = table.Column<string>(nullable: true),
                    Remaining_of_task = table.Column<string>(nullable: true),
                    Sharing = table.Column<string>(nullable: true),
                    Social_Problem_Slving = table.Column<string>(nullable: true),
                    Taking_Turns = table.Column<string>(nullable: true),
                    Staff_member_name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewBehaviorLog", x => x.BehaviorID);
                });

            migrationBuilder.CreateTable(
                name: "NewBudgetAgreement",
                columns: table => new
                {
                    ClientID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Client_Name = table.Column<string>(nullable: true),
                    Start_Date = table.Column<string>(nullable: true),
                    End_Date = table.Column<string>(nullable: true),
                    Select_Program = table.Column<string>(nullable: true),
                    Support_purpose = table.Column<string>(nullable: true),
                    Support_category = table.Column<string>(nullable: true),
                    Budget = table.Column<string>(nullable: true),
                    Remaining_budget = table.Column<string>(nullable: true),
                    Biler_type = table.Column<string>(nullable: true),
                    Support_Item = table.Column<string>(nullable: true),
                    Biller_type = table.Column<string>(nullable: true),
                    Service_Provider = table.Column<string>(nullable: true),
                    Ration = table.Column<string>(nullable: true),
                    SVC_Booking = table.Column<string>(nullable: true),
                    Qty_week = table.Column<string>(nullable: true),
                    Week = table.Column<string>(nullable: true),
                    Total_units = table.Column<string>(nullable: true),
                    Unit_of_measure = table.Column<string>(nullable: true),
                    Unit_Price = table.Column<string>(nullable: true),
                    Total_price = table.Column<string>(nullable: true),
                    Description_of_costs = table.Column<string>(nullable: true),
                    Biller = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    Debtor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewBudgetAgreement", x => x.ClientID);
                });

            migrationBuilder.CreateTable(
                name: "NewFortnightlySafety",
                columns: table => new
                {
                    Reference = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Unite = table.Column<string>(nullable: true),
                    Entry_date = table.Column<string>(nullable: true),
                    Week_ending_date = table.Column<string>(nullable: true),
                    Test_smoke_detectiors_and_identify_below = table.Column<string>(nullable: true),
                    How_the_fire_extingusher_and_the_fire_blanket_been_inspected_in_the_last_6_months = table.Column<string>(nullable: true),
                    Glass_Sprill_management_kits = table.Column<string>(nullable: true),
                    First_aid_kit_contents_Ckecked = table.Column<string>(nullable: true),
                    Cylcone_kit_contents_have_been_cheked = table.Column<string>(nullable: true),
                    Staff = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewFortnightlySafety", x => x.Reference);
                });

            migrationBuilder.CreateTable(
                name: "NewIncidentLog",
                columns: table => new
                {
                    ClientID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Client = table.Column<string>(nullable: true),
                    EntryDtae = table.Column<string>(nullable: true),
                    Heirarchy = table.Column<string>(nullable: true),
                    IncidentType = table.Column<string>(nullable: true),
                    IncidentDate = table.Column<string>(nullable: true),
                    IncidentTime = table.Column<string>(nullable: true),
                    IncidentLocation = table.Column<string>(nullable: true),
                    IncidentWitnesses = table.Column<string>(nullable: true),
                    EmergencyAssistance = table.Column<string>(nullable: true),
                    PoliceInvolvement = table.Column<string>(nullable: true),
                    PersonSearch = table.Column<string>(nullable: true),
                    PersonRoomSearch = table.Column<string>(nullable: true),
                    PRNProvided = table.Column<string>(nullable: true),
                    What_was_happening_in_the_time_Before_the_Incident = table.Column<string>(nullable: true),
                    Behaviour = table.Column<string>(nullable: true),
                    How_did_you_de_escalate_the_incident = table.Column<string>(nullable: true),
                    PossibleFunction = table.Column<string>(nullable: true),
                    Consequence = table.Column<string>(nullable: true),
                    Abuse_or_neglect_of_the_Client_ = table.Column<string>(nullable: true),
                    Criminal_Behaviour_Resulting_in_client_being_held_in_Custody = table.Column<string>(nullable: true),
                    Death_of_fatal_injury_of_a_carer_community_member = table.Column<string>(nullable: true),
                    Death_or_fatal_injury_of_a_client_serious_injury_of_the_client = table.Column<string>(nullable: true),
                    Unlawful_sexual_or_physical_contact_with_or_assault_of_the_client = table.Column<string>(nullable: true),
                    Sexual_misconduct_committed_against_or_in_the_presence_of_the_client_including_grooming_of_the_client_for_sexual_activity = table.Column<string>(nullable: true),
                    Unautherized_use_of_restriced_practice_in_relation_to_the_client = table.Column<string>(nullable: true),
                    Reportable_conduct_by_a_carer_staff_member = table.Column<string>(nullable: true),
                    Category_of_incident = table.Column<string>(nullable: true),
                    Rating_of_Incident = table.Column<string>(nullable: true),
                    Risk_of_significant_ham_reported = table.Column<string>(nullable: true),
                    SignificantHamDate = table.Column<string>(nullable: true),
                    SignificantHamTIme = table.Column<string>(nullable: true),
                    SignificantHamReferanceNumber = table.Column<string>(nullable: true),
                    PhysicalIntervention = table.Column<string>(nullable: true),
                    Type_of_physical_intervention = table.Column<string>(nullable: true),
                    How_long_did_the_physical_intervention_last = table.Column<string>(nullable: true),
                    ClientInjury = table.Column<string>(nullable: true),
                    StaffInjury = table.Column<string>(nullable: true),
                    Has_the_client_been_offered_diffusion_or_debrief = table.Column<string>(nullable: true),
                    Has_the_client_disclosed_or_made_accusation_of_assult_or_abuse = table.Column<string>(nullable: true),
                    Has_the_client_or_guardian_been_made_aware_of_their_right_to_involve_the_police_and_potentially_press_changes = table.Column<string>(nullable: true),
                    Has_the_staff_been_offered_diffusion_or_debrief = table.Column<string>(nullable: true),
                    Has_the_staff_member_been_made_aware_of_their_right_of_involve_the_police_and_potentially_press_charges = table.Column<string>(nullable: true),
                    FollowUpRequired = table.Column<string>(nullable: true),
                    WasOnCallContacted = table.Column<string>(nullable: true),
                    NatureOfAll = table.Column<string>(nullable: true),
                    Result = table.Column<string>(nullable: true),
                    FollowUp = table.Column<string>(nullable: true),
                    StaffMember = table.Column<string>(nullable: true),
                    Signature = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewIncidentLog", x => x.ClientID);
                });

            migrationBuilder.CreateTable(
                name: "NewMentalHealthReview",
                columns: table => new
                {
                    ClientID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Client_Name = table.Column<string>(nullable: true),
                    Entry_date = table.Column<string>(nullable: true),
                    Hierarchy = table.Column<string>(nullable: true),
                    Client_status = table.Column<string>(nullable: true),
                    Question_1 = table.Column<string>(nullable: true),
                    Question_2 = table.Column<string>(nullable: true),
                    Question_3 = table.Column<string>(nullable: true),
                    Question_4 = table.Column<string>(nullable: true),
                    Question_5 = table.Column<string>(nullable: true),
                    Summery = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewMentalHealthReview", x => x.ClientID);
                });

            migrationBuilder.CreateTable(
                name: "NewPSA35",
                columns: table => new
                {
                    ClientID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Client_name = table.Column<string>(nullable: true),
                    Entry_date = table.Column<string>(nullable: true),
                    Hierarchy = table.Column<string>(nullable: true),
                    Complains_of_aches_and_pains = table.Column<string>(nullable: true),
                    Spends_more_time_alone = table.Column<string>(nullable: true),
                    Tires_easily_has_little_energy = table.Column<string>(nullable: true),
                    Fidgety_unable_to_sit_still = table.Column<string>(nullable: true),
                    Has_trouble_with_teacher = table.Column<string>(nullable: true),
                    Less_interested_in_school = table.Column<string>(nullable: true),
                    Acts_as_if_driven_by_a_motor = table.Column<string>(nullable: true),
                    Daydreams_too_much = table.Column<string>(nullable: true),
                    Distracted_easily = table.Column<string>(nullable: true),
                    Is_afraid_of_new_situations = table.Column<string>(nullable: true),
                    Feels_sad_unhappy = table.Column<string>(nullable: true),
                    Is_irritable_angry = table.Column<string>(nullable: true),
                    Feels_hopeless = table.Column<string>(nullable: true),
                    Has_trouble_concentrating = table.Column<string>(nullable: true),
                    Less_interested_in_friends = table.Column<string>(nullable: true),
                    Fights_with_other_children = table.Column<string>(nullable: true),
                    Absent_from_school = table.Column<string>(nullable: true),
                    School_grades_dropping = table.Column<string>(nullable: true),
                    Is_down_on_him_or_herself = table.Column<string>(nullable: true),
                    Has_trouble_sleeping = table.Column<string>(nullable: true),
                    Worries_a_lot = table.Column<string>(nullable: true),
                    Wants_to_be_with_you_more_than_before = table.Column<string>(nullable: true),
                    Feels_he_or_she_is_bad = table.Column<string>(nullable: true),
                    Takes_unnecessary_risks = table.Column<string>(nullable: true),
                    Gets_hurt_frequently = table.Column<string>(nullable: true),
                    Seems_to_be_having_less_fun = table.Column<string>(nullable: true),
                    Acts_younger_than_children_his_or_her_age = table.Column<string>(nullable: true),
                    Does_not_listen_to_rules = table.Column<string>(nullable: true),
                    Does_not_show_feelings = table.Column<string>(nullable: true),
                    Does_not_understand_feelings_of_other_people = table.Column<string>(nullable: true),
                    Teases_others = table.Column<string>(nullable: true),
                    Blames_others_for_his_or_her_troubles = table.Column<string>(nullable: true),
                    Refuses_to_share = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewPSA35", x => x.ClientID);
                });

            migrationBuilder.CreateTable(
                name: "NewServiceLog",
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
                    Finish_time = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewServiceLog", x => x.Reference);
                });

            migrationBuilder.CreateTable(
                name: "Patient",
                columns: table => new
                {
                    PatientID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Full_Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    Telephone = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Supervisor = table.Column<string>(nullable: true),
                    Emergency_Contact_Name = table.Column<string>(nullable: true),
                    Emergency_Contact_No = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patient", x => x.PatientID);
                });

            migrationBuilder.CreateTable(
                name: "PSA35",
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
                    table.PrimaryKey("PK_PSA35", x => x.Reference);
                });

            migrationBuilder.CreateTable(
                name: "RestrictivePracticeRecord",
                columns: table => new
                {
                    Reference = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Client = table.Column<string>(nullable: true),
                    Unit = table.Column<string>(nullable: true),
                    EntryDate = table.Column<string>(nullable: true),
                    LastUpdate = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestrictivePracticeRecord", x => x.Reference);
                });

            migrationBuilder.CreateTable(
                name: "RoleMenus",
                columns: table => new
                {
                    MenuId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Menu = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleMenus", x => x.MenuId);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "ServiceSchedules",
                columns: table => new
                {
                    Reference = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Client_name = table.Column<string>(nullable: true),
                    Start_date_and_time = table.Column<string>(nullable: true),
                    End_date_and_time = table.Column<string>(nullable: true),
                    Day_of_week = table.Column<string>(nullable: true),
                    Hierarchy = table.Column<string>(nullable: true),
                    Service = table.Column<string>(nullable: true),
                    Staff = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceSchedules", x => x.Reference);
                });

            migrationBuilder.CreateTable(
                name: "ShiftLogAM",
                columns: table => new
                {
                    Reference = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Client = table.Column<string>(nullable: true),
                    Unit = table.Column<string>(nullable: true),
                    EntryDate = table.Column<string>(nullable: true),
                    LastUpdate = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShiftLogAM", x => x.Reference);
                });

            migrationBuilder.CreateTable(
                name: "ShiftLogNight",
                columns: table => new
                {
                    Reference = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Client = table.Column<string>(nullable: true),
                    Unit = table.Column<string>(nullable: true),
                    EntryDate = table.Column<string>(nullable: true),
                    LastUpdate = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShiftLogNight", x => x.Reference);
                });

            migrationBuilder.CreateTable(
                name: "ShiftLogPM",
                columns: table => new
                {
                    Reference = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Client = table.Column<string>(nullable: true),
                    Unit = table.Column<string>(nullable: true),
                    EntryDate = table.Column<string>(nullable: true),
                    LastUpdate = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShiftLogPM", x => x.Reference);
                });

            migrationBuilder.CreateTable(
                name: "SLESProgress",
                columns: table => new
                {
                    Reference = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Client = table.Column<string>(nullable: true),
                    Unit = table.Column<string>(nullable: true),
                    EntryDate = table.Column<string>(nullable: true),
                    LastUpdate = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SLESProgress", x => x.Reference);
                });

            migrationBuilder.CreateTable(
                name: "StaffMeeting",
                columns: table => new
                {
                    Reference = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Staff = table.Column<string>(nullable: true),
                    Unit = table.Column<string>(nullable: true),
                    Entry_Date = table.Column<string>(nullable: true),
                    Last_Updated = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffMeeting", x => x.Reference);
                });

            migrationBuilder.CreateTable(
                name: "SupporCoordination",
                columns: table => new
                {
                    Reference = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Client = table.Column<string>(nullable: true),
                    Unit = table.Column<string>(nullable: true),
                    EntryDate = table.Column<string>(nullable: true),
                    LastUpdate = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupporCoordination", x => x.Reference);
                });

            migrationBuilder.CreateTable(
                name: "RoleOptions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Add = table.Column<int>(nullable: false),
                    Edit = table.Column<int>(nullable: false),
                    Delete = table.Column<int>(nullable: false),
                    View = table.Column<int>(nullable: false),
                    Approve = table.Column<int>(nullable: false),
                    addFolder = table.Column<int>(nullable: false),
                    EditFolder = table.Column<int>(nullable: false),
                    RoleMenuId = table.Column<int>(nullable: false),
                    RoleMenusMenuId = table.Column<int>(nullable: true),
                    RoleId = table.Column<int>(nullable: false),
                    RolesRoleId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleOptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleOptions_RoleMenus_RoleMenusMenuId",
                        column: x => x.RoleMenusMenuId,
                        principalTable: "RoleMenus",
                        principalColumn: "MenuId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RoleOptions_Roles_RolesRoleId",
                        column: x => x.RolesRoleId,
                        principalTable: "Roles",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    role = table.Column<string>(nullable: true),
                    username = table.Column<string>(nullable: true),
                    password = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    RoleId = table.Column<int>(nullable: false),
                    RolesRoleId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RolesRoleId",
                        column: x => x.RolesRoleId,
                        principalTable: "Roles",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RoleOptions_RoleMenusMenuId",
                table: "RoleOptions",
                column: "RoleMenusMenuId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleOptions_RolesRoleId",
                table: "RoleOptions",
                column: "RolesRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RolesRoleId",
                table: "Users",
                column: "RolesRoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActiveLogMain");

            migrationBuilder.DropTable(
                name: "AddNewFoodAndFluid");

            migrationBuilder.DropTable(
                name: "AddNewRestrictivePraticeRecord");

            migrationBuilder.DropTable(
                name: "AddNewShiftLogAM");

            migrationBuilder.DropTable(
                name: "AddNewShiftLogNight");

            migrationBuilder.DropTable(
                name: "AddNewShiftLogPM");

            migrationBuilder.DropTable(
                name: "AddNewSLESProgress");

            migrationBuilder.DropTable(
                name: "AddNewStaffMeeting");

            migrationBuilder.DropTable(
                name: "AddNewSupportCoordination");

            migrationBuilder.DropTable(
                name: "ApprovedTb");

            migrationBuilder.DropTable(
                name: "BehaviorLog");

            migrationBuilder.DropTable(
                name: "BudgetAgreement");

            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "EmergencyFireEvacutionDrill");

            migrationBuilder.DropTable(
                name: "FireDrill");

            migrationBuilder.DropTable(
                name: "FoodAndFluid");

            migrationBuilder.DropTable(
                name: "Fortnighttly");

            migrationBuilder.DropTable(
                name: "IncidentLog");

            migrationBuilder.DropTable(
                name: "InvoiceTb");

            migrationBuilder.DropTable(
                name: "Medication");

            migrationBuilder.DropTable(
                name: "Medication_main");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "NewBehaviorLog");

            migrationBuilder.DropTable(
                name: "NewBudgetAgreement");

            migrationBuilder.DropTable(
                name: "NewFortnightlySafety");

            migrationBuilder.DropTable(
                name: "NewIncidentLog");

            migrationBuilder.DropTable(
                name: "NewMentalHealthReview");

            migrationBuilder.DropTable(
                name: "NewPSA35");

            migrationBuilder.DropTable(
                name: "NewServiceLog");

            migrationBuilder.DropTable(
                name: "Patient");

            migrationBuilder.DropTable(
                name: "PSA35");

            migrationBuilder.DropTable(
                name: "RestrictivePracticeRecord");

            migrationBuilder.DropTable(
                name: "RoleOptions");

            migrationBuilder.DropTable(
                name: "ServiceSchedules");

            migrationBuilder.DropTable(
                name: "ShiftLogAM");

            migrationBuilder.DropTable(
                name: "ShiftLogNight");

            migrationBuilder.DropTable(
                name: "ShiftLogPM");

            migrationBuilder.DropTable(
                name: "SLESProgress");

            migrationBuilder.DropTable(
                name: "StaffMeeting");

            migrationBuilder.DropTable(
                name: "SupporCoordination");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "RoleMenus");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
