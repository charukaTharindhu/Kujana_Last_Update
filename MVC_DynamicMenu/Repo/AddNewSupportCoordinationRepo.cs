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
    public class AddNewSupportCoordinationRepo
    {
        private readonly DynamicMenuDBContext _context = null;

        public AddNewSupportCoordinationRepo(DynamicMenuDBContext context)
        {
            _context = context;
        }

        public void AddNewSupportCoordination(AddNewSupportCoordination sc)
        {
            var NewSC = new AddNewSupportCoordination
            {
                Client_name = sc.Client_name,
                EntryDate = sc.EntryDate,
                Heirarchy = sc.Heirarchy,
                Date = sc.Date,
                Time = sc.Time,
                Type_of_support_coordination_activity = sc.Type_of_support_coordination_activity,
                ContactType = sc.ContactType,
                ServiceType = sc.ServiceType,
                Billable_non_billable_time = sc.Billable_non_billable_time,
                Purpose = sc.Purpose,
                Outcome = sc.Outcome,
                FollowUp = sc.FollowUp,
                Duration = sc.Duration,
                StaffName = sc.StaffName,
                StaffSignature = sc.StaffSignature,
                Name = sc.Name
            };

            _context.AddNewSupportCoordination.Add(NewSC);
            _context.SaveChanges();
        }

        public List<AddNewSupportCoordination> ShowAllSupportCoordinations()
        {
            var obj = _context.AddNewSupportCoordination
            .FromSqlRaw("SELECT * FROM dbo.AddNewSupportCoordination")
            .ToList();

            return obj;
        }

        public AddNewSupportCoordination getClientById(int id)
        {
            var obj = _context.AddNewSupportCoordination
            .FromSqlRaw("SELECT * FROM dbo.AddNewSupportCoordination WHERE ClientID=" + id)
            .ToList();

            return obj[0];
        }
        public void UpdateSupportC(AddNewSupportCoordination model)
        {
            _context.AddNewSupportCoordination.Update(model);
            _context.SaveChanges();
        }

        public void DeleteSC(int id)
        {
            var SC = _context.AddNewSupportCoordination.FirstOrDefault(x => x.ClientID == id);
            if (SC != null)
            {
                _context.AddNewSupportCoordination.Remove(SC);
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
