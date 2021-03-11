using MVC_DynamicMenu.Data;
using MVC_DynamicMenu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_DynamicMenu.Repo
{
    public class FoodAndFluidRepo
    {
        private readonly DynamicMenuDBContext _context = null;

        public FoodAndFluidRepo(DynamicMenuDBContext context)
        {
            _context = context;
        }

        public void AddNewFoodAndFluid(FoodAndFluid foodAndFluid)
        {
            var newFF = new FoodAndFluid
            {
                ClientID = foodAndFluid.ClientID,
                Client_Name = foodAndFluid.Client_Name,
                Approved_Plane = foodAndFluid.Approved_Plane,
                Pending_Plans = foodAndFluid.Pending_Plans
            };

            _context.FoodAndFluid.Add(newFF);
            _context.SaveChanges();
        }
    }
}
