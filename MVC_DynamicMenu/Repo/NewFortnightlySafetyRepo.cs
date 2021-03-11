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
    public class NewFortnightlySafetyRepo
    {
        private readonly DynamicMenuDBContext _c = null;

        public NewFortnightlySafetyRepo(DynamicMenuDBContext c)
        {
            _c = c;
        }

        public void AddNewFS(NewFortnightlySafety model)
        {
            NewFortnightlySafety newFS = new NewFortnightlySafety
            {
                Reference = model.Reference,
                Entry_date = model.Entry_date,
                Cylcone_kit_contents_have_been_cheked = model.Cylcone_kit_contents_have_been_cheked,
                First_aid_kit_contents_Ckecked = model.First_aid_kit_contents_Ckecked,
                Glass_Sprill_management_kits = model.Glass_Sprill_management_kits,
                How_the_fire_extingusher_and_the_fire_blanket_been_inspected_in_the_last_6_months = model.How_the_fire_extingusher_and_the_fire_blanket_been_inspected_in_the_last_6_months,
                Staff = model.Staff,
                Test_smoke_detectiors_and_identify_below = model.Test_smoke_detectiors_and_identify_below,
                Unite = model.Unite,
                Week_ending_date = model.Week_ending_date
            };

           _c.NewFortnightlySafety.Add(newFS);
            _c.SaveChanges();
        }

        public List<NewFortnightlySafety> getAllFortnightlySafety()
        {
            var obj = _c.NewFortnightlySafety
                .FromSqlRaw("Select * from dbo.NewFortnightlySafety")
                .ToList();

                return obj;
        }

        public NewFortnightlySafety getFSByID(int id)
        {
            var obj = _c.NewFortnightlySafety
                .FromSqlRaw("Select * from dbo.NewFortnightlySafety where Reference =" + id)
                .ToList();

            return obj[0];
        }

        public void UpdateFS(NewFortnightlySafety model)
        {
            _c.NewFortnightlySafety.Update(model);
            _c.SaveChanges();
        }

        public void DeleteFS(int id)
        {
            var FS = _c.NewFortnightlySafety.FirstOrDefault(x => x.Reference == id);
            if (FS != null)
            {
                _c.NewFortnightlySafety.Remove(FS);
                _c.SaveChanges();
            }
        }

        public string GetPatients()
        {
            var obj = _c.Patient.FromSqlRaw("SELECT * FROM dbo.Patient").ToList();
            var patients = JsonConvert.SerializeObject(obj);
            return patients;
        }
    }
}
