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
    public class AddNewShiftLogAMRepo
    {
        private readonly DynamicMenuDBContext _context;

        public AddNewShiftLogAMRepo(DynamicMenuDBContext context)
        {
            _context = context;
        }

        public void AddNewShiftLogAM(AddNewShiftLogAM SLAM)
        {
            var newSLAM = new AddNewShiftLogAM
            {
                Client = SLAM.Client,
                EntryDate = SLAM.EntryDate,
                Hierarchy = SLAM.Hierarchy,
                Authorised_substance_use_protocol_adhered_to = SLAM.Authorised_substance_use_protocol_adhered_to,
                Behavior_Emotional_issues = SLAM.Behavior_Emotional_issues,
                Chore_plane_followed = SLAM.Chore_plane_followed,
                Daily_planed_adheared_to = SLAM.Daily_planed_adheared_to,
                Education_has_the_client_Attended_school_today = SLAM.Education_has_the_client_Attended_school_today,
                Excercise_plane_followed = SLAM.Excercise_plane_followed,
                Incident_log_copleted = SLAM.Incident_log_copleted,
                Medication_Administrated_as_Prescribed = SLAM.Medication_Administrated_as_Prescribed,
                Menu_Diet_plane_folowed = SLAM.Menu_Diet_plane_folowed,
                Personal_core_routine_Followed = SLAM.Personal_core_routine_Followed,
                PRN_administrered = SLAM.PRN_administrered,
                Rainforcement_points_achivevede = SLAM.Rainforcement_points_achivevede,
                Wake_up_routine_followed = SLAM.Wake_up_routine_followed,
                Progress_note = SLAM.Progress_note,
                Staff_member_name = SLAM.Staff_member_name
            };
            _context.AddNewShiftLogAM.Add(newSLAM);
            _context.SaveChanges();
        }
        public List<AddNewShiftLogAM> GetAllAddNewShiftLogAM()
        {
            var obj = _context.AddNewShiftLogAM
                .FromSqlRaw("SELECT * FROM dbo.AddNewShiftLogAM")
                .ToList();

            return obj;
        }

        public AddNewShiftLogAM getShiftById(int id)
        {
            var obj = _context.AddNewShiftLogAM
            .FromSqlRaw("SELECT * FROM dbo.AddNewShiftLogAM WHERE ClientID=" + id)
            .ToList();

            return obj[0];
        }
        public void UpdateShiftLogAM(AddNewShiftLogAM model)
        {
            _context.AddNewShiftLogAM.Update(model);
            _context.SaveChanges();
        }

        public void DeleteShiftLogAM(int id)
        {
            var logAm = _context.AddNewShiftLogAM.FirstOrDefault(x => x.ClientID == id);
            if (logAm != null)
            {
                _context.AddNewShiftLogAM.Remove(logAm);
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
