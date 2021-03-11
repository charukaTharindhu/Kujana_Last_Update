using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC_DynamicMenu.Models;
using MVC_DynamicMenu.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_DynamicMenu.Controllers
{
    public class AddNewFoodAndFluidController : Controller
    {
        private readonly AddNewFoodAndFluidRepo _context = null;

        public AddNewFoodAndFluidController(AddNewFoodAndFluidRepo context)
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
        public ViewResult AddNewFoodAndFluid(AddNewFoodAndFluid FF)
        {
            _context.AddNewFoodAndFluid(FF);
            return View();
        }

        public ViewResult ShowAllFoodAndFluid()
        {
            HttpContext.Session.SetString("FoodsAndFluids", _context.GetPatients());
            List<AddNewFoodAndFluid> FF = _context.getAllFoodAndFluid();
            List<FoodAndFluid> ff = new List<FoodAndFluid>();

            foreach (var item in FF)
            {
                FoodAndFluid ff1 = new FoodAndFluid
                {
                    ClientID = item.ClientID,
                    Client_Name = item.Client_Name,
                    Approved_Plane = item.Status,
                    Pending_Plans = item.Status
                };

                ff.Add(ff1);
            }
            return View(ff);

        }
        [HttpGet]
        public ViewResult UpdateFoodAndFluid(int id)
        {
            AddNewFoodAndFluid FF = _context.getFFById(id);
            return View(FF);
        }

        [HttpGet]
        public ViewResult ViewFoodAndFluid(int id)
        {
            AddNewFoodAndFluid FF = _context.getFFById(id);
            return View(FF);
        }

        [Route("/AddNewFoodAndFluid/DeleteFoodAndFluid/{id:int}")]
        public ActionResult DeleteFoodAndFluid(int id)
        {
            _context.DeleteFoodAndFluid(id);
            return RedirectPermanent("/AddNewFoodAndFluid/ActiveLogMain");
        }

        [HttpPost]
        public ActionResult UpdateFoodAndFluid(AddNewFoodAndFluid model)
        {
            _context.UpdateFoodAndFluid(model);
            return RedirectPermanent("/Client/ActiveLogMain");
        }


    }
}
