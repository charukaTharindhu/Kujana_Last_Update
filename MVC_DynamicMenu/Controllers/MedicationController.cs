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
	public class MedicationController : Controller
	{
		private readonly MedicineRepo _medRepo = null;

		public MedicationController(MedicineRepo medicineRepo)
		{
			_medRepo = medicineRepo;
		}
		public IActionResult Index()
		{
			return View();
		}

		[HttpGet]
		[Route("Medication/MedicationApprove/{id:int}")]
		public ActionResult MedicationApprove(int id)
		{
			_medRepo.approvemed(id);
			return RedirectPermanent("/Medication/MedicationMain");
		}

		[HttpGet]
		public ActionResult AddMedication()
		{
			return View();
		}
		[HttpGet]
		public ActionResult MedicationMain()
		{
			HttpContext.Session.SetString("medication", _medRepo.GetPatients());
			var obj = _medRepo.getMedicationMain();
			return View(obj);
		}

		[HttpPost]
		public ActionResult AddMedication(Medication model)
		{
			_medRepo.AddNewMed(model);
			return View();
		}

		[Route("/Medication/PlanView/{id:int}")]
		[HttpGet]
		public ActionResult PlanView(int id)
		{
			var obj = _medRepo.getMedicationbyId(id);
			return View(obj);
		}

		[Route("/Medication/EditPlan/{id:int}")]
		[HttpGet]
		public ActionResult EditPlan(int id)
		{
			var obj = _medRepo.getMedicationplanId(id);
			return View(obj);
		}


		[HttpPost]
		public ActionResult EditPlan(Medication model)
		{
			_medRepo.updatemed(model);
			return RedirectPermanent("/Medication/MedicationMain");
		}




	}
}
