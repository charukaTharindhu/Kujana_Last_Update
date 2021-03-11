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
    public class AddNewShiftLogPMRepo
    {
        private readonly DynamicMenuDBContext _context;

        public AddNewShiftLogPMRepo(DynamicMenuDBContext context)
        {
            _context = context;
        }

        public void AddNewShiftLogPM(AddNewShiftLogPM SLPM)
        {
            var newSLPM = new AddNewShiftLogPM
            {
                Client = SLPM.Client,
                EntryDate = SLPM.EntryDate,
                Hierarchy = SLPM.Hierarchy,
                Authorised_substance_use_protocol_adhered_to = SLPM.Authorised_substance_use_protocol_adhered_to,
                Behavior_Emotional_issues = SLPM.Behavior_Emotional_issues,
                Chore_plane_followed = SLPM.Chore_plane_followed,
                Daily_planed_adheared_to = SLPM.Daily_planed_adheared_to,
                Education_has_the_client_Attended_school_today = SLPM.Education_has_the_client_Attended_school_today,
                Excercise_plane_followed = SLPM.Excercise_plane_followed,
                Incident_log_copleted = SLPM.Incident_log_copleted,
                Medication_Administrated_as_Prescribed = SLPM.Medication_Administrated_as_Prescribed,
                Menu_Diet_plane_folowed = SLPM.Menu_Diet_plane_folowed,
                Personal_core_routine_Followed = SLPM.Personal_core_routine_Followed,
                PRN_administrered = SLPM.PRN_administrered,
                Rainforcement_points_achivevede = SLPM.Rainforcement_points_achivevede,
                Wake_up_routine_followed = SLPM.Wake_up_routine_followed,
                Progress_note = SLPM.Progress_note,
                Staff_member_name = SLPM.Staff_member_name
            };
            _context.AddNewShiftLogPM.Add(newSLPM);
            _context.SaveChanges();
        }

        public List<AddNewShiftLogPM> GetAllAddNewShiftLogPM()
        {
            var obj = _context.AddNewShiftLogPM
                .FromSqlRaw("SELECT * FROM dbo.AddNewShiftLogPM")
                .ToList();

            return obj;
        }

        public AddNewShiftLogPM getShiftById(int id)
        {
            var obj = _context.AddNewShiftLogPM
            .FromSqlRaw("SELECT * FROM dbo.AddNewShiftLogPM WHERE ClientID=" + id)
            .ToList();

            return obj[0];
        }
        public void UpdateShiftLogPM(AddNewShiftLogPM model)
        {
            _context.AddNewShiftLogPM.Update(model);
            _context.SaveChanges();
        }

        public void DeleteShiftLogPM(int id)
        {
            var logPm = _context.AddNewShiftLogPM.FirstOrDefault(x => x.ClientID == id);
            if (logPm != null)
            {
                _context.AddNewShiftLogPM.Remove(logPm);
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
