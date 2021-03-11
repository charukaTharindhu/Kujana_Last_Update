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
    public class ShiftLogAMController : Controller
    {
        private readonly AddNewShiftLogAMRepo _context;

        public ShiftLogAMController(AddNewShiftLogAMRepo context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public ViewResult AddNewShiftLogAM()
        {
            return View();
        }
        [HttpPost]

        public ViewResult AddNewShiftLogAM(AddNewShiftLogAM newSLAM)
        {
            _context.AddNewShiftLogAM(newSLAM);
            return View();
        }

        public ViewResult GetAllAddNewShiftLogAM()
        {
            HttpContext.Session.SetString("AM", _context.GetPatients());
            List<AddNewShiftLogAM> NewAM = _context.GetAllAddNewShiftLogAM();
            List<ShiftLogAM> newAm = new List<ShiftLogAM>();

            foreach (var item in NewAM)
            {
                ShiftLogAM newAM1 = new ShiftLogAM
                {
                    Client = item.Client,
                    EntryDate = item.EntryDate,
                    LastUpdate = item.EntryDate,
                    Reference = item.ClientID,
                    Unit = "Counsiling"
                };
                newAm.Add(newAM1);
            }
            return View(newAm);

        }

        [HttpGet]
        public ViewResult UpdateShiftLogAM(int id)
        {
            AddNewShiftLogAM shiftLogAM = _context.getShiftById(id);
            return View(shiftLogAM);
        }

        [HttpGet]
        public ViewResult ViewShiftLogAM(int id)
        {
            AddNewShiftLogAM shiftLogAM = _context.getShiftById(id);
            return View(shiftLogAM);
        }

        [Route("/AddNewShiftLogAM/DeleteShiftLogAM/{id:int}")]
        public ActionResult DeleteShiftLogAM(int id)
        {
            _context.DeleteShiftLogAM(id);
            return RedirectPermanent("/ShiftLogAM/GetAllAddNewShiftLogAM");
        }

        [HttpPost]
        public ActionResult UpdateShiftLogAM(AddNewShiftLogAM model)
        {
            _context.UpdateShiftLogAM(model);
            return RedirectPermanent("/ShiftLogAM/GetAllAddNewShiftLogAM");
        }
    }
}
