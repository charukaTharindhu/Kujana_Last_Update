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
    public class RestrictivePracticeRecordRepo
    {
        private readonly DynamicMenuDBContext _context;

        public RestrictivePracticeRecordRepo(DynamicMenuDBContext context)
        {
            _context = context;
        }

        public void AddNewRestrictivePractice(AddNewRestrictivePraticeRecord rp)
        {
            var newRP = new AddNewRestrictivePraticeRecord
            {
                Client = rp.Client,
                EntryDate = rp.EntryDate,
                Hierarchy = rp.Hierarchy,
                NDIS_practice_number = rp.NDIS_practice_number,
                Date_restrictive_practice_used = rp.Date_restrictive_practice_used,
                Time_ceased = rp.Time_ceased,
                Duration_minutes = rp.Duration_minutes,
                What_type_of_restrictive_practice_used = rp.What_type_of_restrictive_practice_used,
                Brief_description_of_the_practice = rp.Brief_description_of_the_practice,
                Routine_or_PRN = rp.Routine_or_PRN,
                Number_of_time_used = rp.Number_of_time_used,
                Incident_report_refference_number = rp.Incident_report_refference_number,
                Circumstances_before_using_restrictive_practice = rp.Circumstances_before_using_restrictive_practice,
                Related_behaviour_of_Concem = rp.Related_behaviour_of_Concem,
                If_other_please_specify = rp.If_other_please_specify,
                PlaneID = rp.PlaneID,
                If_no_planeID_select_the_relevent_BSP_status = rp.If_no_planeID_select_the_relevent_BSP_status,
                Authorised_status = rp.Authorised_status,
                Medication = rp.Medication,
                Dosage = rp.Dosage,
                Unite_of_Measurment = rp.Unite_of_Measurment,
                Frequency = rp.Frequency,
                StaffName = rp.StaffName,
                Signature = rp.Signature,
                Name = rp.Name,
                Time_commenced = rp.Time_commenced
            };

            _context.AddNewRestrictivePraticeRecord.Add(newRP);
            _context.SaveChanges();
        }

        public List<AddNewRestrictivePraticeRecord> ShowAllRestrctivePractices()
        {
            var obj = _context.AddNewRestrictivePraticeRecord
            .FromSqlRaw("SELECT * FROM dbo.AddNewRestrictivePraticeRecord")
            .ToList();

            return obj;
        }

        public AddNewRestrictivePraticeRecord getPracticeById(int id)
        {
            var obj = _context.AddNewRestrictivePraticeRecord
            .FromSqlRaw("SELECT * FROM dbo.AddNewRestrictivePraticeRecord WHERE ClientID=" + id)
            .ToList();

            return obj[0];
        }
        public void UpdateRP(AddNewRestrictivePraticeRecord model)
        {
            _context.AddNewRestrictivePraticeRecord.Update(model);
            _context.SaveChanges();
        }

        public void DeleteRP(int id)
        {
            var RP = _context.AddNewRestrictivePraticeRecord.FirstOrDefault(x => x.ClientID == id);
            if (RP != null)
            {
                _context.AddNewRestrictivePraticeRecord.Remove(RP);
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
