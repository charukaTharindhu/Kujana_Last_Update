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
    public class MentalHealthReviewController : Controller
    {
        private readonly MentalHealthReviewRepo _c = null;

        public MentalHealthReviewController(MentalHealthReviewRepo c)
        {
            _c = c;
        }

        public ViewResult ShowAllMHReviews()
        {
            HttpContext.Session.SetString("mental", _c.GetPatients());
            List<NewMentalHealthReview> MHReviews = _c.GetAllMHReviews();
            List<MentalHealthReview> newMH = new List<MentalHealthReview>();

            foreach (var item in MHReviews)
            {
                MentalHealthReview newMH1 = new MentalHealthReview
                {
                    Reference = item.ClientID,
                    Client = item.Client_Name,
                    Entry_Date = item.Entry_date,
                    Last_Updated = item.Entry_date,
                    Unit = "Counseling"
                };
                newMH.Add(newMH1);
            }
            return View(newMH);
        }

        public IActionResult Index()
        {
            return View();
        }
        public ViewResult AddNewMHReviews()
        {
            return View();
        }

        [HttpPost]
        public ViewResult AddNewMHReviews(NewMentalHealthReview model)
        {
            _c.AddNewMHReview(model);
            return View();
        }

        [HttpGet]
        public ViewResult UpdateMHReviews(int id)
        {
            NewMentalHealthReview newMH = _c.GetMHReviewsById(id);
            return View(newMH);
        }

        [HttpGet]
        public ViewResult ViewMHReviews(int id)
        {
            NewMentalHealthReview newMH = _c.GetMHReviewsById(id);
            return View(newMH);
        }

        [HttpPost]
        public ActionResult UpdateMHReviews(NewMentalHealthReview model)
        {
            _c.UpdateMHReviews(model);
            return RedirectPermanent("/MentalHealthReview/ShowAllMHReviews");
        }

        [Route("/MentalHealthReview/UpdateMHReviews/{id:int}")]
        public ActionResult DeleteMHRiview(int id)
        {
            _c.DeleteMHReviews(id);
            return RedirectPermanent("/MentalHealthReview/ShowAllMHReviews");
        }
    }
}
