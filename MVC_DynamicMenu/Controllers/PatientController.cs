using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC_DynamicMenu.Data;
using MVC_DynamicMenu.Models;
using MVC_DynamicMenu.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_DynamicMenu.Controllers
{
    public class PatientController : Controller
    {
        private readonly PatientRepo _context;

        public PatientController(PatientRepo context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ViewResult AddNewPatient()
        {
            return View();
        }
        [HttpPost]
        public ViewResult AddNewPatient(Patient patient)
        {
            _context.AddNewPatient(patient);
            return View();
        }

        public ViewResult ShowPatients()
        {
            HttpContext.Session.SetString("patient", _context.GetPatients());
            List<Patient> us = _context.getAllPatients();
            return View(us);
        }

        [HttpGet]
        public ActionResult UpdatePatient(int id)
        {
            Patient us = _context.getUserById(id);
            return View(us);
        }

        [HttpGet]
        public ActionResult ViewPatient(int id)
        {
            Patient us = _context.getUserById(id);
            return View(us);
        }

        [Route("/Patient/DeletePatient/{id:int}")]
        public ActionResult DeletePatient(int id)
        {
            _context.DeletePatient(id);
            return RedirectPermanent("/Patient/ShowPatients");

        }


        [HttpPost]
        public ActionResult UpdatePatient(Patient model)
        {
            _context.UpdatePatient(model);
            return RedirectPermanent("/Patient/ShowPatients");
        }
    }
}
