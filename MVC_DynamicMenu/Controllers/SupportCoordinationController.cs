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
    public class SupportCoordinationController : Controller
    {
        private readonly AddNewSupportCoordinationRepo _context;

        public SupportCoordinationController(AddNewSupportCoordinationRepo context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public ViewResult AddNewSupportCoordination()
        {
            return View();
        }

        [HttpPost]

        public ViewResult AddNewSupportCoordination(AddNewSupportCoordination SC)
        {
            _context.AddNewSupportCoordination(SC);
            return View();
        }

        public ViewResult ShowAllSupportCoordinations()
        {
            HttpContext.Session.SetString("support", _context.GetPatients());
            List<AddNewSupportCoordination> newSC = _context.ShowAllSupportCoordinations();
            List<SupporCoordination> SC = new List<SupporCoordination>();

            foreach (var item in newSC)
            {
                SupporCoordination SC1 = new SupporCoordination
                {
                    Reference = item.ClientID,
                    EntryDate = item.EntryDate,
                    LastUpdate = item.EntryDate,
                    Unit = "Counceling",
                    Client = item.Client_name

                };
                SC.Add(SC1);
            }

            return View(SC);
        }

        [HttpGet]
        public ViewResult UpdateSupportC(int id)
        {
            AddNewSupportCoordination SC = _context.getClientById(id);
            return View(SC);
        }

        [HttpGet]
        public ViewResult ViewSupportC(int id)
        {
            AddNewSupportCoordination SC = _context.getClientById(id);
            return View(SC);
        }

        [Route("/SupportCoordination/DeleteActivityLog/{id:int}")]
        public ActionResult DeleteSupportC(int id)
        {
            _context.DeleteSC(id);
            return RedirectPermanent("/SupportCoordination/ShowAllSupportCoordinations");
        }

        [HttpPost]
        public ActionResult UpdateSupportC(AddNewSupportCoordination model)
        {
            _context.UpdateSupportC(model);
            return RedirectPermanent("/SupportCoordination/ShowAllSupportCoordinations");
        }
    }
}
