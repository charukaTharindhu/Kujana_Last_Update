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
    public class TherapyLogController : Controller
    {

        private readonly TherapyLogRepo _c = null;

        public TherapyLogController(TherapyLogRepo c)
        {
            _c = c;
        }
        [HttpGet]
        public ViewResult ShowAllTL()
        {
            HttpContext.Session.SetString("therapy", _c.GetPatients());
            List<NewTherapyLog> TL = _c.GetAllTL();
            List<TherapyLog> newTL = new List<TherapyLog>();

            foreach (var item in TL)
            {
                TherapyLog newTL1 = new TherapyLog
                {
                    Reference = item.ClientID,
                    Client = item.Client_Name,
                    Entry_Date = item.Entry_date,
                    Last_Updated = item.Entry_date,
                    Unit = "Counseling"
                };
                newTL.Add(newTL1);
            }
            return View(newTL);
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ViewResult AddNewTL()
        {
            return View();
        }

        [HttpPost]
        public ViewResult AddNewTL(NewTherapyLog model)
        {
            _c.AddNewTL(model);
            return View();
        }

        [HttpGet]
        public ViewResult UpdateTL(int id)
        {
            NewTherapyLog newTL = _c.GetMHTLById(id);
            return View(newTL);
        }

        [HttpGet]
        public ViewResult ViewTL(int id)
        {
            NewTherapyLog newMH = _c.GetMHTLById(id);
            return View(newMH);
        }

        [HttpPost]
        public ActionResult UpdateTL(NewTherapyLog model)
        {
            _c.UpdateTL(model);
            return RedirectPermanent("/TherapyLog/ShowAllTL");
        }

        [Route("/TherapyLog/DeleteTL/{id:int}")]
        public ActionResult DeleteMHRiview(int id)
        {
            _c.DeleteTL(id);
            return RedirectPermanent("/TherapyLog/ShowAllTL");
        }
    }
}
