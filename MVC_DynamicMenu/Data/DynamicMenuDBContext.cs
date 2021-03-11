using Microsoft.EntityFrameworkCore;
using MVC_DynamicMenu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_DynamicMenu.Data
{
    public class DynamicMenuDBContext:DbContext
    {
        public DbSet<Users> Users { get; set; }
        public DbSet<Menus> Menus { get; set; }

        public DbSet<Client> Client { get; set; }
        public DbSet<ActiveLogMain> ActiveLogMain{ get; set; }


        public DbSet<BehaviorLog> BehaviorLog { get; set; }
        public DbSet<NewBehaviorLog> NewBehaviorLog { get; set; }

        public DbSet<IncidentLog> IncidentLog { get; set; }
        public DbSet<NewIncidentLog> NewIncidentLog { get; set; }


        public DbSet<SupporCoordination> SupporCoordination { get; set; }
        public DbSet<AddNewSupportCoordination> AddNewSupportCoordination { get; set; }

        public DbSet<SLESProgress> SLESProgress { get; set; }
        public DbSet<AddNewSLESProgress> AddNewSLESProgress { get; set; }

        public DbSet<RestrictivePracticeRecord> RestrictivePracticeRecord { get; set; }
        public DbSet<AddNewRestrictivePraticeRecord> AddNewRestrictivePraticeRecord { get; set; }

        public DbSet<ShiftLogAM> ShiftLogAM { get; set; }
        public DbSet<AddNewShiftLogAM> AddNewShiftLogAM { get; set; }

        public DbSet<ShiftLogPM> ShiftLogPM { get; set; }
        public DbSet<AddNewShiftLogPM> AddNewShiftLogPM { get; set; }


        public DbSet<ShiftLogNight> ShiftLogNight { get; set; }
        public DbSet<AddNewShiftLogNight> AddNewShiftLogNight { get; set; }

        public DbSet<Patient> Patient { get; set; }

        public DbSet<Medication> Medication { get; set; }
        public DbSet<Medication_main> Medication_main { get; set; }

        public DbSet<FoodAndFluid> FoodAndFluid { get; set; }
        public DbSet<AddNewFoodAndFluid> AddNewFoodAndFluid { get; set; }

        public DbSet<NewPSA35> NewPSA35 { get; set; }
        public DbSet<PSA35> PSA35 { get; set; }

        public DbSet<AddNewStaffMeeting> AddNewStaffMeeting { get; set; }
        public DbSet<StaffMeeting> StaffMeeting { get; set; }

        public DbSet<EmergencyFireEvacutionDrill> EmergencyFireEvacutionDrill { get; set; }
        public DbSet<FireDrill> FireDrill { get; set; }


        public DbSet<NewFortnightlySafety> NewFortnightlySafety { get; set; }
        public DbSet<Fortnighttly> Fortnighttly { get; set; }

        public DbSet<NewMentalHealthReview> NewMentalHealthReview { get; set; }

        public DbSet<NewBudgetAgreement> NewBudgetAgreement { get; set; }
        public DbSet<BudgetAgreement> BudgetAgreement { get; set; }

        public DbSet<ServiceSchedules> ServiceSchedules { get; set; }
        public DbSet<LogSchedule> NewServiceLog { get; set; }

        public DbSet<ApprovedTb> ApprovedTb { get; set; }
        public DbSet<InvoiceTb> InvoiceTb { get; set; }

        public DbSet<Roles> Roles { get; set; }
        public DbSet<RoleOptions> RoleOptions { get; set; }
        public DbSet<RoleMenus> RoleMenus { get; set; }

        public DbSet<TherapyLog> TherapyLog { get; set; }
        public DbSet<NewTherapyLog> NewTherapyLog { get; set; }

        public DbSet<LogSchedule> LogSchedule { get; set; }
        public DbSet<Patient_Contact> Patient_Contact { get; set; }

        public DbSet<Patient_Info> Patient_Info { get; set; }
        public DbSet<Summerising> Summerising { get; set; }

        public DbSet<Patient_Helth> Patient_Helth { get; set; }
        public DbSet<Programs> Programs { get; set; }


        public DbSet<Case_Worker> Case_Worker { get; set; }
        public DbSet<Housing_Register_Application> Housing_Register_Application { get; set; }
        public DbSet<CareTeams> CareTeams  { get; set; }

        public DbSet<Commencement_Issuse> Commencement_Issuse { get; set; }

        







        public DynamicMenuDBContext(DbContextOptions<DynamicMenuDBContext> option) : base(option)
        {

        }
    }
}
