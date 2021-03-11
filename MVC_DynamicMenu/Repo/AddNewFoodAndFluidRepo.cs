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
    public class AddNewFoodAndFluidRepo
    {
        private readonly DynamicMenuDBContext _context = null;

        public AddNewFoodAndFluidRepo(DynamicMenuDBContext context)
        {
            _context = context;
        }

        public void AddNewFoodAndFluid(AddNewFoodAndFluid FF)
        {
            var newFF = new AddNewFoodAndFluid
            {
                ClientID = FF.ClientID,
                Client_Name = FF.Client_Name,
                Start_date = FF.Start_date,
                End_date = FF.End_date,
                Breakfast = FF.Breakfast,
                Lunch = FF.Lunch,
                Diner = FF.Diner,
                Additional_Food = FF.Additional_Food,
                Breakfast_Fluid = FF.Breakfast_Fluid,
                Diner_Fluid = FF.Diner_Fluid,
                Lunch_Fluid = FF.Lunch_Fluid,
                Toal_Calories = FF.Toal_Calories,
                Staf_Name = FF.Staf_Name
            };
            _context.AddNewFoodAndFluid.Add(newFF);
            _context.SaveChanges();
        }

        public List<AddNewFoodAndFluid> getAllFoodAndFluid()
        {
            var obj = _context.AddNewFoodAndFluid
                .FromSqlRaw("SELECT * FROM dbo.AddNewFoodAndFluid")
                .ToList();

            return obj;
        }

        public AddNewFoodAndFluid getFFById(int id)
        {
            var obj = _context.AddNewFoodAndFluid
            .FromSqlRaw("SELECT * FROM dbo.AddNewFoodAndFluid WHERE ClientID=" + id)
            .ToList();

            return obj[0];
        }
        public void UpdateFoodAndFluid(AddNewFoodAndFluid model)
        {
            _context.AddNewFoodAndFluid.Update(model);
            _context.SaveChanges();
        }

        public void DeleteFoodAndFluid(int id)
        {
            var FF = _context.AddNewFoodAndFluid.FirstOrDefault(x => x.ClientID == id);
            if (FF != null)
            {
                _context.AddNewFoodAndFluid.Remove(FF);
                _context.SaveChanges();
            }
        }

        public String GetPatients()
        {
            var obj = _context.Patient.FromSqlRaw("Select * From dbo.Patient").ToList();
            var patients = JsonConvert.SerializeObject(obj);

            return patients;
        }
    }
}
