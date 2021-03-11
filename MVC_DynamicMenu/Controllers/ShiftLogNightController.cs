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
    public class ShiftLogNightController : Controller
    {
        private readonly AddNewShiftLogNightRepo _context;

        public ShiftLogNightController(AddNewShiftLogNightRepo context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public ViewResult AddNewShiftLogNight()
        {
            return View();
        }
        [HttpPost]

        public ViewResult AddNewShiftLogNight(AddNewShiftLogNight newSLAM)
        {
            _context.AddNewShiftLogNight(newSLAM);
            return View();
        }

        public ViewResult GetAllAddNewShiftLogNight()
        {
            HttpContext.Session.SetString("night", _context.GetPatients());
            List<AddNewShiftLogNight> NewNight = _context.GetAllAddNewShiftLogNight();
            List<ShiftLogNight> newNight = new List<ShiftLogNight>();

            foreach (var item in NewNight)
            {
                ShiftLogNight newNight1 = new ShiftLogNight
                {
                    Client = item.Client,
                    EntryDate = item.EntryDate,
                    LastUpdate = item.EntryDate,
                    Reference = item.ClientID,
                    Unit = "Counsiling"
                };
                newNight.Add(newNight1);
            }
            return View(newNight);

        }


        [HttpGet]
        public ViewResult UpdateShiftLogNight(int id)
        {
            AddNewShiftLogNight shiftLogNight = _context.getShiftById(id);
            return View(shiftLogNight);
        }

        [HttpGet]
        public ViewResult ViewShiftLogNight(int id)
        {
            AddNewShiftLogNight shiftLogNight = _context.getShiftById(id);
            return View(shiftLogNight);
        }

        [Route("/AddNewShiftLogNight/DeleteShiftLogNight/{id:int}")]
        public ActionResult DeleteShiftLogNight(int id)
        {
            _context.DeleteShiftLogNight(id);
            return RedirectPermanent("/ShiftLogNight/GetAllAddNewShiftLogNight");
        }

        [HttpPost]
        public ActionResult UpdateShiftLogNight(AddNewShiftLogNight model)
        {
            _context.UpdateShiftLogNight(model);
            return RedirectPermanent("/ShiftLogNight/GetAllAddNewShiftLogNight");
        }
    }
}
