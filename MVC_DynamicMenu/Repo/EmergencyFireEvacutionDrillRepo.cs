using Microsoft.EntityFrameworkCore;
using MVC_DynamicMenu.Data;
using MVC_DynamicMenu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_DynamicMenu.Repo
{
    public class EmergencyFireEvacutionDrillRepo
    {
        private readonly DynamicMenuDBContext _c = null;

        public EmergencyFireEvacutionDrillRepo(DynamicMenuDBContext c)
        {
            _c = c;
        }
        public void AddNewFireDrill(EmergencyFireEvacutionDrill FD)
        {
            var newFD = new EmergencyFireEvacutionDrill
            {
                Reference = FD.Reference,
                Date = FD.Date,
                Describe_the_evacuation = FD.Describe_the_evacuation,
                Entry_Date = FD.Entry_Date,
                Location_of_fire = FD.Location_of_fire,
                Participants_present_at_the_fire_drill = FD.Participants_present_at_the_fire_drill,
                Staff_name = FD.Staff_name,
                Time = FD.Time,
                Unit = FD.Unit,
                What_worked = FD.What_worked,
                Where_any_changes_made_to_how_you_evacute = FD.Where_any_changes_made_to_how_you_evacute,
                Where_there_any_risks_identified = FD.Where_there_any_risks_identified,
                Work_Unit = FD.Work_Unit
           
            };

            _c.EmergencyFireEvacutionDrill.Add(newFD);
            _c.SaveChanges();
        }

       public List<EmergencyFireEvacutionDrill> getAllFD()
        {
            var obj = _c.EmergencyFireEvacutionDrill
                .FromSqlRaw("Select * From dbo.EmergencyFireEvacutionDrill")
                .ToList();

            return obj;
        }

        public EmergencyFireEvacutionDrill getFDByID(int id)
        {
            var obj = _c.EmergencyFireEvacutionDrill
                .FromSqlRaw("Select * From dbo.EmergencyFireEvacutionDrill where Reference =" + id)
                .ToList();

            return obj[0];
        }

        public void UpdateFD(EmergencyFireEvacutionDrill model)
        {
            _c.EmergencyFireEvacutionDrill.Update(model);
            _c.SaveChanges();
        }

        public void DeleteFD(int id)
        {
            var FD = _c.EmergencyFireEvacutionDrill.FirstOrDefault(x => x.Reference == id);
            if (FD != null)
            {
                _c.EmergencyFireEvacutionDrill.Remove(FD);
                _c.SaveChanges();
            }
        }
    }
}
