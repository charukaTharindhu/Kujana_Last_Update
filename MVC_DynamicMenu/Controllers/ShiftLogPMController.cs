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
    public class ShiftLogPMController : Controller
    {
        private readonly AddNewShiftLogPMRepo _context;

        public ShiftLogPMController(AddNewShiftLogPMRepo context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public ViewResult AddNewShiftLogPM()
        {
            return View();
        }
        [HttpPost]

        public ViewResult AddNewShiftLogPM(AddNewShiftLogPM newSLPM)
        {
            _context.AddNewShiftLogPM(newSLPM);
            return View();
        }

        public ViewResult GetAllAddNewShiftLogPM()
        {
            HttpContext.Session.SetString("PM", _context.GetPatients());
            List<AddNewShiftLogPM> NewPM = _context.GetAllAddNewShiftLogPM();
            List<ShiftLogPM> newPM = new List<ShiftLogPM>();

            foreach (var item in NewPM)
            {
                ShiftLogPM newPM1 = new ShiftLogPM
                {
                    Client = item.Client,
                    EntryDate = item.EntryDate,
                    LastUpdate = item.EntryDate,
                    Reference = item.ClientID,
                    Unit = "Counsiling"
                };
                newPM.Add(newPM1);
            }
            return View(newPM);

        }

        [HttpGet]
        public ViewResult UpdateShiftLogPM(int id)
        {
            AddNewShiftLogPM shiftLogPM = _context.getShiftById(id);
            return View(shiftLogPM);
        }

        [HttpGet]
        public ViewResult ViewShiftLogPM(int id)
        {
            AddNewShiftLogPM shiftLogPM = _context.getShiftById(id);
            return View(shiftLogPM);
        }

        [Route("/AddNewShiftLogPM/DeleteShiftLogPM/{id:int}")]
        public ActionResult DeleteShiftLogPM(int id)
        {
            _context.DeleteShiftLogPM(id);
            return RedirectPermanent("/ShiftLogPM/GetAllAddNewShiftLogPM");
        }

        [HttpPost]
        public ActionResult UpdateShiftLogPM(AddNewShiftLogPM model)
        {
            _context.UpdateShiftLogPM(model);
            return RedirectPermanent("/ShiftLogPM/GetAllAddNewShiftLogPM");
        }
    }
}
