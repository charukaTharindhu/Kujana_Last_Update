using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MVC_DynamicMenu.Data;
using MVC_DynamicMenu.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_DynamicMenu
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<DynamicMenuDBContext>(options =>
                options.UseSqlServer(
                Configuration.GetConnectionString("DefaultConnection")));
            services.AddControllersWithViews();
            services.AddRazorPages();
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(15); // It depends on user requirements.
                
            });
            services.AddScoped<UserRepo, UserRepo>();
            services.AddScoped<ClientRepo, ClientRepo>();
            services.AddScoped<BehaviorLogRepo, BehaviorLogRepo>();
            services.AddScoped<NewBehaviorLogRepo, NewBehaviorLogRepo>();
            services.AddScoped<NewIncidentRepo, NewIncidentRepo>();
            services.AddScoped<ActiveLogMainRepo, ActiveLogMainRepo>();
            services.AddScoped<AddNewSupportCoordinationRepo, AddNewSupportCoordinationRepo>();
            services.AddScoped<AddNewSLESProgressRepo, AddNewSLESProgressRepo>();
            services.AddScoped<RestrictivePracticeRecordRepo, RestrictivePracticeRecordRepo>();
            services.AddScoped<AddNewShiftLogAMRepo, AddNewShiftLogAMRepo>();
            services.AddScoped<AddNewShiftLogPMRepo, AddNewShiftLogPMRepo>();
            services.AddScoped<AddNewShiftLogNightRepo, AddNewShiftLogNightRepo>();
            services.AddScoped<ActiveLogMainRepo, ActiveLogMainRepo>();
            services.AddScoped<PatientRepo, PatientRepo>();
            services.AddScoped<AddNewFoodAndFluidRepo, AddNewFoodAndFluidRepo>();
            services.AddScoped<PSA35Repo, PSA35Repo>();
            services.AddScoped<NewStaffMeetingRepo, NewStaffMeetingRepo>();
            services.AddScoped<EmergencyFireEvacutionDrillRepo, EmergencyFireEvacutionDrillRepo>();
            services.AddScoped<NewFortnightlySafetyRepo, NewFortnightlySafetyRepo>();
            services.AddScoped<MentalHealthReviewRepo, MentalHealthReviewRepo>();
            services.AddScoped<BudgetAgreementRepo, BudgetAgreementRepo>();
            services.AddScoped<MedicineRepo, MedicineRepo>();
            services.AddScoped<TherapyLogRepo, TherapyLogRepo>();
            services.AddScoped<ServiceSchedulesRepo, ServiceSchedulesRepo>();
            services.AddScoped<Patient_ContactRepo, Patient_ContactRepo>();
            



        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseSession();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                   name: "default",
                   pattern: "{controller=Userpemission}/{action=Index}/{id?}");
              
            });
        }
    }
}
