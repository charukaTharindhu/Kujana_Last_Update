using Microsoft.AspNetCore.Mvc;
using MVC_DynamicMenu.Data;
using MVC_DynamicMenu.Models;
using MVC_DynamicMenu.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_DynamicMenu.Controllers
{
    public class FoodAndFluidController : Controller
    {
        private readonly FoodAndFluidRepo _context =null;

        public FoodAndFluidController(FoodAndFluidRepo context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public ViewResult AddNewFoodAndFluid()
        {
            return View();
        }
        
        [HttpPost]
        public ViewResult AddNewFoodAndFluid(FoodAndFluid foodAndFluid)
        {
            _context.AddNewFoodAndFluid(foodAndFluid);
            return View();
        }


    }
}
