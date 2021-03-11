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
    public class StaffAndMeetingController : Controller
    {
        private readonly NewStaffMeetingRepo _c = null;

        public StaffAndMeetingController(NewStaffMeetingRepo c)
        {
            _c = c;
        }

        public IActionResult Index()
        {
            return View();
        }

        public ViewResult AddNewStaffMeeting()
        {
            return View();
        }

        [HttpPost]
        public ViewResult AddNewStaffMeeting(AddNewStaffMeeting model)
        {
            _c.AddNewStaffMeeting(model);
            return View();
        }

        public ViewResult GetAllSM()
        {
            HttpContext.Session.SetString("staff", _c.GetPatients());
            List<AddNewStaffMeeting> SM = _c.getAllSM();
            List<StaffMeeting> sm = new List<StaffMeeting>();

            foreach (var item in SM)
            {
                StaffMeeting newsm = new StaffMeeting
                {
                    Reference = item.Reference,
                    Staff = item.Client_Name,
                    Entry_Date = item.Entry_Date,
                    Last_Updated = item.Entry_Date,
                    Unit = "Counseling"
                };
                sm.Add(newsm);
            }
            return View(sm);
        }
        [HttpGet]
        public ViewResult UpdateSM(int id)
        {
            AddNewStaffMeeting sm = _c.GetSMByID(id);
            return View(sm);
        }

        [HttpGet]
        public ViewResult ViewSM(int id)
        {
            AddNewStaffMeeting sm = _c.GetSMByID(id);
            return View(sm);
        }

        [HttpPost]
        public ActionResult UpdateSM(AddNewStaffMeeting model)
        {
            _c.UpdateSM(model);
            return RedirectPermanent("/StaffAndMeeting/GetAllSM");
        }

        [HttpGet]
        public ActionResult DeleteSM(int id)
        {
            _c.DeleteSM(id);
            return RedirectPermanent("/StaffAndMeeting/GetAllSM");
        }

    }
}
