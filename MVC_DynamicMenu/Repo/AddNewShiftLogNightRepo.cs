using Microsoft.EntityFrameworkCore;
using MVC_DynamicMenu.Data;
using MVC_DynamicMenu.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_DynamicMenu.Repo
{
    public class AddNewShiftLogNightRepo
    {
        private readonly DynamicMenuDBContext _context;

        public AddNewShiftLogNightRepo(DynamicMenuDBContext context)
        {
            _context = context;
        }

        public void AddNewShiftLogNight(AddNewShiftLogNight SLNight)
        {
            var newSLNight = new AddNewShiftLogNight
            {
                Client = SLNight.Client,
                EntryDate = SLNight.EntryDate,
                Hierarchy = SLNight.Hierarchy,
                Authorised_substance_use_protocol_adhered_to = SLNight.Authorised_substance_use_protocol_adhered_to,
                Behavior_Emotional_issues = SLNight.Behavior_Emotional_issues,
                Chore_plane_followed = SLNight.Chore_plane_followed,
                Daily_planed_adheared_to = SLNight.Daily_planed_adheared_to,
                Education_has_the_client_Attended_school_today = SLNight.Education_has_the_client_Attended_school_today,
                Excercise_plane_followed = SLNight.Excercise_plane_followed,
                Incident_log_copleted = SLNight.Incident_log_copleted,
                Medication_Administrated_as_Prescribed = SLNight.Medication_Administrated_as_Prescribed,
                Menu_Diet_plane_folowed = SLNight.Menu_Diet_plane_folowed,
                Personal_core_routine_Followed = SLNight.Personal_core_routine_Followed,
                PRN_administrered = SLNight.PRN_administrered,
                Rainforcement_points_achivevede = SLNight.Rainforcement_points_achivevede,
                Wake_up_routine_followed = SLNight.Wake_up_routine_followed,
                Progress_note = SLNight.Progress_note,
                Staff_member_name = SLNight.Staff_member_name
            };
            _context.AddNewShiftLogNight.Add(newSLNight);
            _context.SaveChanges();
        }

        public List<AddNewShiftLogNight> GetAllAddNewShiftLogNight()
        {
            var obj = _context.AddNewShiftLogNight
                .FromSqlRaw("SELECT * FROM dbo.AddNewShiftLogNight")
                .ToList();

            return obj;
        }

        public AddNewShiftLogNight getShiftById(int id)
        {
            var obj = _context.AddNewShiftLogNight
            .FromSqlRaw("SELECT * FROM dbo.AddNewShiftLogNight WHERE ClientID=" + id)
            .ToList();

            return obj[0];
        }
        public void UpdateShiftLogNight(AddNewShiftLogNight model)
        {
            _context.AddNewShiftLogNight.Update(model);
            _context.SaveChanges();
        }

        public void DeleteShiftLogNight(int id)
        {
            var logNight = _context.AddNewShiftLogNight.FirstOrDefault(x => x.ClientID == id);
            if (logNight != null)
            {
                _context.AddNewShiftLogNight.Remove(logNight);
                _context.SaveChanges();
            }
        }

        public string GetPatients()
        {
            var obj = _context.Patient.FromSqlRaw("SELECT * FROM dbo.Patient").ToList();
            var patients = JsonConvert.SerializeObject(obj);
            return patients;
        }

    }
}
