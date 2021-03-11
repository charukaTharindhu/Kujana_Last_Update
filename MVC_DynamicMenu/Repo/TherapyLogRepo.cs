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
    public class TherapyLogRepo
    {
        private readonly DynamicMenuDBContext _c = null;

        public TherapyLogRepo(DynamicMenuDBContext c)
        {
            _c = c;
        }

        public void AddNewTL(NewTherapyLog model)
        {
            var newMH = new NewTherapyLog
            {
                ClientID = model.ClientID,
                Client_Name = model.Client_Name,
                Entry_date = model.Entry_date,
                Hierarchy = model.Hierarchy,
                Mental_After_Therapy = model.Mental_After_Therapy,
                Mental_Before_Therapy = model.Mental_Before_Therapy,
                Mental_Client_Concerns = model.Mental_Client_Concerns,
                Mental_Duration_Time = model.Mental_Duration_Time,
                Mental_Exercises = model.Mental_Exercises,
                Mental_Status = model.Mental_Status,
                Physical_After_Therapy = model.Physical_After_Therapy,
                Physical_Before_Therapy = model.Physical_Before_Therapy,
                Physical_Client_Concerns = model.Physical_Client_Concerns,
                Physical_Duration_Time = model.Physical_Duration_Time,
                Physical_Exercises = model.Physical_Exercises,
                Physical_Status = model.Physical_Status,

            };
            _c.NewTherapyLog.Add(newMH);
            _c.SaveChanges();
        }

        public List<NewTherapyLog> GetAllTL()
        {
            var newMH = _c.NewTherapyLog
                .FromSqlRaw("Select * from dbo.NewTherapyLog")
                .ToList();

            return newMH;
        }

        public NewTherapyLog GetMHTLById(int id)
        {
            var newTL = _c.NewTherapyLog
                .FromSqlRaw("Select * from dbo.NewTherapyLog where ClientID =" + id)
                .ToList();

            return newTL[0];
        }

        public void UpdateTL(NewTherapyLog model)
        {
            _c.NewTherapyLog.Update(model);
            _c.SaveChanges();
        }

        public void DeleteTL(int id)
        {
            var TL = _c.NewTherapyLog.FirstOrDefault(x => x.ClientID == id);
            if (TL != null)
            {
                _c.NewTherapyLog.Remove(TL);
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
