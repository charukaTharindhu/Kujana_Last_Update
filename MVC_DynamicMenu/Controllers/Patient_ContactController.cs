using Microsoft.AspNetCore.Mvc;
using MVC_DynamicMenu.Models;
using MVC_DynamicMenu.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_DynamicMenu.Controllers
{
    public class Patient_ContactController : Controller
    {
        private readonly Patient_ContactRepo _c = null;

        public Patient_ContactController(Patient_ContactRepo C)
        {
            _c = C;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ViewResult AddNewParticipant()
        {
            return View();
        }
        [HttpPost]
        public ViewResult AddNewParticipant(Patient model)
        {
            Patient_Contact pc = new Patient_Contact();
            pc = model.patient_Contacts[0];

            Patient_Info pi = new Patient_Info();
            pi = model.Patient_Info[0];

            Summerising sum = new Summerising();
            sum = model.summerisings[0];

            Patient_Helth helth = new Patient_Helth();
            helth = model.patient_Helths[0];

            Programs pro = new Programs();
            pro = model.programs[0];

            Case_Worker cw = new Case_Worker();
            cw = model.Case_Worker[0];

            Housing_Register_Application house = new Housing_Register_Application();
            house = model.Housing_Register_Application[0];

            CareTeams ct = new CareTeams();
            ct = model.CareTeams[0];

            Commencement_Issuse ci = new Commencement_Issuse();
            ci = model.Commencement_Issuse[0];

            _c.AddNewPatient_Contact(pc);
            _c.AddNewPatient_Info(pi);
            _c.AddNewSummerising(sum);
            _c.AddNewPatient_Helth(helth);
            _c.AddNewProgramm(pro);
            _c.AddNewCase_Worker(cw);
            _c.Addhouser(house);
            _c.AddNewCareTeams(ct);
            _c.AddNewCommencement_Issuse(ci);

            return View();
        }

    }
}
