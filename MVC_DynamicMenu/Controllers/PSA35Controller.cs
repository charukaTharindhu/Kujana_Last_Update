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
    public class PSA35Controller : Controller
    {
        private readonly PSA35Repo _c = null;

        public PSA35Controller(PSA35Repo c)
        {
            _c = c;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ViewResult AddNewPSA35()
        {
            return View();
        }
        [HttpPost]
        public ViewResult AddNewPSA35(NewPSA35 newPsa)
        {
            _c.AddNewPSA35(newPsa);
            return View();
        }
        [HttpGet]
        public ViewResult ShowAllPSA35()
        {
            HttpContext.Session.SetString("newPsa35", _c.GetPatients());
            List<NewPSA35> PSA = _c.GetAllSPAs();
            List<PSA35> psa = new List<PSA35>();

            foreach (var item in PSA)
            {
                PSA35 pas35 = new PSA35
                {
                    Reference = item.ClientID,
                    Client = item.Client_name,
                    Entry_Date = item.Entry_date,
                    Last_Updated = item.Entry_date,
                    Unit = "Counseling"
                };
                psa.Add(pas35);
            }
            return View(psa);
        }
        [HttpGet]
        public ViewResult UpdatePSA35(int id)
        {
            NewPSA35 psa = _c.getPSAByID(id);
            return View(psa);
        }

        [HttpGet]
        public ViewResult ViewPSA35(int id)
        {
            NewPSA35 psa = _c.getPSAByID(id);
            return View(psa);
        }

        [HttpPost]
        public ActionResult UpdatePSA35(NewPSA35 model)
        {
            _c.UpdatePSA35(model);
            return RedirectPermanent("/PSA35/ShowAllPSA35");
        }

        [Route("NewPSA35/DeletePSA35/{id:int}")]
        public ActionResult DeletePSA35(int id)
        {
            _c.DeletePSA35(id);
            return RedirectPermanent("/PSA35/ShowAllPSA35");
        }


    }
}
