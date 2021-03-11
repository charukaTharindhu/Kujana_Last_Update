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
    public class AddNewSLESProgressRepo
    {
        private readonly DynamicMenuDBContext _context;

        public AddNewSLESProgressRepo(DynamicMenuDBContext context)
        {
            _context = context;
        }

        public void AddNewSLES(AddNewSLESProgress SLES)
        {
            var AddNewSLES = new AddNewSLESProgress
            {

                Client = SLES.Client,
                EntryDate = SLES.EntryDate,
                Hierarchy = SLES.Hierarchy,
                Date = SLES.Date,
                TypeOfContact = SLES.TypeOfContact,
                Activity = SLES.Activity,
                AnyBarrierssIdentified = SLES.AnyBarrierssIdentified,
                If_yes_list_barriers_identifieed = SLES.If_yes_list_barriers_identifieed,
                Step_taken_to_Address_beriers = SLES.Step_taken_to_Address_beriers,
                Duration = SLES.Duration,
                StaffName = SLES.StaffName
            };
            _context.AddNewSLESProgress.Add(AddNewSLES);
            _context.SaveChanges();
        }

        public List<AddNewSLESProgress> AddNewSELES()
        {
            var obj = _context.AddNewSLESProgress
                .FromSqlRaw("SELECT * FROM dbo.AddNewSLESProgress")
                .ToList();

            return obj;
        }

        public AddNewSLESProgress getSlesById(int id)
        {
            var obj = _context.AddNewSLESProgress
            .FromSqlRaw("SELECT * FROM dbo.AddNewSLESProgress WHERE ClientID=" + id)
            .ToList();

            return obj[0];
        }

        public void UpdateSLES(AddNewSLESProgress model)
        {
            _context.AddNewSLESProgress.Update(model);
            _context.SaveChanges();
        }

        public void DeleteSLES(int id)
        {
            var sles = _context.AddNewSLESProgress.FirstOrDefault(x => x.ClientID == id);
            if (sles != null)
            {
                _context.AddNewSLESProgress.Remove(sles);
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
