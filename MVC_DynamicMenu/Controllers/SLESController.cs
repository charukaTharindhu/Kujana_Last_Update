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
    public class SLESController : Controller
    {
        private readonly AddNewSLESProgressRepo _context;

        public SLESController(AddNewSLESProgressRepo context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public ViewResult AddNewSLES()
        {
            return View();
        }
        [HttpPost]

        public ViewResult AddNewSLES(AddNewSLESProgress SLES)
        {
            _context.AddNewSLES(SLES);
            return View();
        }

        [HttpGet]
        public ViewResult ShowALLSLESProgresses()
        {
            HttpContext.Session.SetString("sles", _context.GetPatients());
            List<AddNewSLESProgress> newSLES = _context.AddNewSELES();
            List<SLESProgress> newSles = new List<SLESProgress>();

            foreach (var item in newSLES)
            {
                SLESProgress newSles1 = new SLESProgress
                {
                    Client = item.Client,
                    EntryDate = item.EntryDate,
                    LastUpdate = item.EntryDate,
                    Reference = item.ClientID,
                    Unit = "Counseling"
                };
                newSles.Add(newSles1);
            }
            return View(newSles);
        }

        [HttpGet]
        public ViewResult UpdateSLES(int id)
        {
            AddNewSLESProgress sles = _context.getSlesById(id);
            return View(sles);
        }

        [HttpGet]
        public ViewResult ViewSLES(int id)
        {
            AddNewSLESProgress sles = _context.getSlesById(id);
            return View(sles);
        }

        [Route("/AddNewSLESProgress/DeleteSLES/{id:int}")]
        public ActionResult DeleteSLES(int id)
        {
            _context.DeleteSLES(id);
            return RedirectPermanent("/SLES/ShowALLSLESProgresses");
        }

        [HttpPost]
        public ActionResult UpdateSLES(AddNewSLESProgress model)
        {
            _context.UpdateSLES(model);
            return RedirectPermanent("/SLES/ShowALLSLESProgresses");
        }

    }
}
