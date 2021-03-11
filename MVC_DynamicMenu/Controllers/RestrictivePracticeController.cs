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
    public class RestrictivePracticeController : Controller
    {
        private readonly RestrictivePracticeRecordRepo _context;

        public RestrictivePracticeController(RestrictivePracticeRecordRepo context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public ViewResult AddNewRestrictivePractice()
        {
            return View();
        }
        [HttpPost]

        public ViewResult AddNewRestrictivePractice(AddNewRestrictivePraticeRecord addNewRP)
        {
            _context.AddNewRestrictivePractice(addNewRP);
            return View();
        }

        public ViewResult ShowAllRestrctivePractices()
        {
            HttpContext.Session.SetString("practice", _context.GetPatients());
            List<AddNewRestrictivePraticeRecord> newRP = _context.ShowAllRestrctivePractices();
            List<RestrictivePracticeRecord> RP = new List<RestrictivePracticeRecord>();

            foreach (var item in newRP)
            {
                RestrictivePracticeRecord RP1 = new RestrictivePracticeRecord
                {
                    Client = item.Client,
                    EntryDate = item.EntryDate,
                    LastUpdate = item.EntryDate,
                    Reference = item.ClientID,
                    Unit = "Counceling"
                };
                RP.Add(RP1);
            }

            return View(RP);
        }

        [HttpGet]
        public ViewResult UpdateRP(int id)
        {
            AddNewRestrictivePraticeRecord RP = _context.getPracticeById(id);
            return View(RP);
        }

        [HttpGet]
        public ViewResult ViewRP(int id)
        {
            AddNewRestrictivePraticeRecord RP = _context.getPracticeById(id);
            return View(RP);
        }

        [Route("/AddNewRestrictivePraticeRecord/DeleteRP/{id:int}")]
        public ActionResult DeleteRP(int id)
        {
            _context.DeleteRP(id);
            return RedirectPermanent("/RestrictivePractice/ShowAllRestrctivePractices");
        }

        [HttpPost]
        public ActionResult UpdateRP(AddNewRestrictivePraticeRecord model)
        {
            _context.UpdateRP(model);
            return RedirectPermanent("/RestrictivePractice/ShowAllRestrctivePractices");
        }

    }


}

