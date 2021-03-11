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
    public class NewBudgetAgreementController : Controller
    {
        private readonly BudgetAgreementRepo _c = null;

        public NewBudgetAgreementController(BudgetAgreementRepo c)
        {
            _c = c;
        }

        public ViewResult ShowAllBA()
        {
            HttpContext.Session.SetString("budget", _c.GetPatients());
            List<NewBudgetAgreement> BA = _c.GetAllBA();
            List<BudgetAgreement> newBA = new List<BudgetAgreement>();

            foreach (var item in BA)
            {

                BudgetAgreement newBA1 = new BudgetAgreement
                {
                    Reference = item.ClientID,
                    Client = item.Client_Name,
                    Date_of_birth = item.Start_Date,
                    End_Date = item.End_Date,
                    Start_Date = item.Start_Date,
                    NDIS_ID = item.ClientID
                };
                newBA.Add(newBA1);
            }
            return View(newBA);
        }

        [HttpGet]
        public ViewResult AddNewBudgetAgreement()
        {
            return View();
        }

        [HttpPost]
        public ViewResult AddNewBudgetAgreement(NewBudgetAgreement model)
        {
            _c.AddNewBudgetAgreement(model);
            return View();
        }

        [HttpGet]
        public ActionResult UpdateBA(int id)
        {
            NewBudgetAgreement BA = _c.GetBAByID(id);
            return View(BA);
        }

        [HttpGet]
        public ActionResult ViewBA(int id)
        {
            NewBudgetAgreement BA = _c.GetBAByID(id);
            return View(BA);
        }

        [HttpPost]
        public ActionResult UpdateBA(NewBudgetAgreement model)
        {
            _c.UpdateBA(model);
            return RedirectPermanent("");
        }

        [Route("/NewBudgetAgreement/DeleteBA/{id:int}")]
        public ActionResult DeleteBA(int id)
        {
            _c.DeleteBA(id);
            return RedirectPermanent("");
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
