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
    public class NewIncidentController : Controller
    {
        private readonly NewIncidentRepo _incidentRepo = null;

        public NewIncidentController(NewIncidentRepo incidentRepo)
        {
            _incidentRepo = incidentRepo;
        }
        public IActionResult Index()
        {
            return View();
        }
        public ViewResult AddNewIncident()
        {
            return View();
        }
        [HttpPost]

        public ViewResult AddNewIncident(NewIncidentLog incident)
        {
            _incidentRepo.AddNewIncident(incident);
            return View();
        }

        public ViewResult Incident()
        {
            HttpContext.Session.SetString("incident", _incidentRepo.GetPatients());
            List<NewIncidentLog> newincident = _incidentRepo.getAllActiveLog();
            List<IncidentLog> incident = new List<IncidentLog>();

            foreach (var item in newincident)
            {
                IncidentLog incident1 = new IncidentLog
                {
                   Client = item.Client,
                   ClientID = item.ClientID,
                   EntryDate = item.EntryDtae,
                   LastUpdate = item.EntryDtae,
                   Unit = "Counceling"
                };
                incident.Add(incident1);
            }

            return View(incident);
        }

        [HttpGet]
        public ViewResult UpdateIncident(int id)
        {
            NewIncidentLog incident = _incidentRepo.getUserById(id);
            return View(incident);
        }

        [HttpGet]
        public ViewResult ViewIncident(int id)
        {
            NewIncidentLog incident = _incidentRepo.getUserById(id);
            return View(incident);
        }

        [HttpGet]
        public ActionResult DeleteIncident(int id)
        {
            _incidentRepo.DeleteInceident(id);
            return RedirectPermanent("/NewIncident/Incident");
        }

        [HttpPost]
        public ActionResult UpdateIncident(NewIncidentLog model)
        {
            _incidentRepo.UpdateIncident(model);
            return RedirectPermanent("/NewIncident/Incident");
        }
    }
}
