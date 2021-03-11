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
    public class BudgetAgreementRepo
    {
        private readonly DynamicMenuDBContext _c = null;

        public BudgetAgreementRepo(DynamicMenuDBContext c)
        {
            _c = c;
        }

        public void AddNewBudgetAgreement(NewBudgetAgreement model)
        {
            var newBA = new NewBudgetAgreement
            {
                ClientID = model.ClientID,
                Client_Name = model.Client_Name,
                Biler_type = model.Biler_type,
                Biller = model.Biller,
                Biller_type = model.Biller_type,
                Budget = model.Budget,
                Debtor = model.Debtor,
                Description_of_costs = model.Description_of_costs,
                End_Date = model.End_Date,
                Notes = model.Notes,
                Qty_week = model.Qty_week,
                Ration = model.Ration,
                Remaining_budget = model.Remaining_budget,
                Select_Program = model.Select_Program,
                Service_Provider = model.Service_Provider,
                Support_category = model.Support_category,
                Support_Item = model.Support_Item,
                Support_purpose = model.Support_purpose,
                SVC_Booking = model.SVC_Booking,
                Total_price = model.Total_price,
                Total_units = model.Total_units,
                Unit_of_measure = model.Unit_of_measure,
                Unit_Price = model.Unit_Price,
                Week = model.Week
            };
            _c.NewBudgetAgreement.Add(newBA);
            _c.SaveChanges();
        }

        public List<NewBudgetAgreement> GetAllBA()
        {
            var BA = _c.NewBudgetAgreement
                .FromSqlRaw("Select *  from dbo.NewBudgetAgreement")
                .ToList();

            return BA;
        }

        public NewBudgetAgreement GetBAByID(int id)
        {
            var BA = _c.NewBudgetAgreement
                .FromSqlRaw("Select * from dbo.NewBudgetAgreement where ClientID = " + id)
                .ToList();

            return BA[0];
        }

        public void UpdateBA(NewBudgetAgreement BA)
        {
            _c.NewBudgetAgreement.Update(BA);
            _c.SaveChanges();
        }

        public void DeleteBA(int id)
        {
            var BA = _c.NewBudgetAgreement.FirstOrDefault(x => x.ClientID == id);
            if (BA != null)
            {
                _c.NewBudgetAgreement.Remove(BA);
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
