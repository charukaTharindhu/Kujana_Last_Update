using Microsoft.AspNetCore.Mvc;
using MVC_DynamicMenu.Models;
using MVC_DynamicMenu.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_DynamicMenu.Controllers
{
    public class EmergencyFireEvacutionDrillController : Controller
    {
        private readonly EmergencyFireEvacutionDrillRepo _c = null;

        public EmergencyFireEvacutionDrillController(EmergencyFireEvacutionDrillRepo c)
        {
            _c = c;
        }

        public IActionResult Index()
        {
            return View();
        }

        public ViewResult AddNewFireDrill()
        {
            return View();
        }

        [HttpPost]
        public ViewResult AddNewFireDrill(EmergencyFireEvacutionDrill model)
        {
            _c.AddNewFireDrill(model);
            return View();
            
        }

        public ViewResult ShowAllFD()
        {
            List<EmergencyFireEvacutionDrill> FD = _c.getAllFD();
            List<FireDrill> fd = new List<FireDrill>();

            foreach (var item in FD)
            {
                FireDrill newfd = new FireDrill
                {
                    Reference = item.Reference,
                    Entry_Date = item.Entry_Date,
                    Last_Updated = item.Entry_Date,
                    Unit = "counseling"
                };
                fd.Add(newfd);
            }
            return View(fd);

        }

        [HttpGet]
        public ViewResult UpdateFD(int id)
        {
            EmergencyFireEvacutionDrill FD = _c.getFDByID(id);
            return View(FD);
        }

        [HttpGet]
        public ViewResult ViewFD(int id)
        {
            EmergencyFireEvacutionDrill FD = _c.getFDByID(id);
            return View(FD);
        }


        [HttpPost]
        public ActionResult UpdateFD(EmergencyFireEvacutionDrill model)
        {
            _c.UpdateFD(model);
            return RedirectPermanent("/EmergencyFireEvacutionDrill/ShowAllFD");
        }

        [HttpGet]
        public ActionResult DeleteFD(int id)
        {
            _c.DeleteFD(id);
            return RedirectPermanent("/EmergencyFireEvacutionDrill/ShowAllFD");
        }


    }
}
