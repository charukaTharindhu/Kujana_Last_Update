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
    public class ServiceSchedulesController : Controller
    {
        private readonly ServiceSchedulesRepo _c = null;

        public ServiceSchedulesController(ServiceSchedulesRepo c)
        {
            _c = c;
        }
        public IActionResult Index()
        {
            return View();
        }

        public ViewResult AddNewSS()
        {
            return View();
        }

        [HttpPost]
        public ViewResult AddNewSS(ServiceSchedules ss)
        {
            _c.AddNewServiceSchedule(ss);
            
            return View();
        }

        [HttpGet]
        public ViewResult ShowAllSS()
        {
            HttpContext.Session.SetString("SS", _c.GetPatients());
            List<ServiceSchedules> ss = _c.GetAllSS();
            return View(ss);
        }

        [HttpGet]
        public ViewResult UpdateSS(int id)
        {
            ServiceSchedules SS = _c.GetSSById(id);
            return View(SS);
        }

        [HttpPost]
        public ActionResult UpdateSS(ServiceSchedules model)
        {
            _c.UpdateSS(model);
            return RedirectPermanent("");
        }

        [Route("/ServiceSchedules/Delete/{id:int}")]
        public ActionResult DeleteSS(int id)
        {
            _c.DeleteSS(id);
            return RedirectPermanent("");
        }



        //--------------------------------NewServiceLogController---------------------------------//

        [HttpGet]
        public ActionResult AddNewLog(int id)
        {
            //shere id from SS page to SL page
           HttpContext.Session.SetString("ssid", id.ToString());

            //get service schedule data from repo
            //create object log

            ServiceSchedules SS = _c.GetSSById(id);
            LogSchedule newlog = new LogSchedule();

            newlog.Scheduled_start_date = SS.Start_date_and_time;
            newlog.Scheduled_start_time = SS.Start_date_and_time;
            newlog.Scheduled_finish_date = SS.Start_date_and_time;
            newlog.Scheduled_finish_time = SS.Start_date_and_time;

            newlog.Actual_start_date = SS.Start_date_and_time;
            newlog.Actual_start_time = SS.Start_date_and_time;
            newlog.Actual_finish_date = SS.Start_date_and_time;
            newlog.Actual_finish_time = SS.Start_date_and_time;

            //return model
            ViewBag.Id = id;
            return View(newlog);
        }

        [HttpPost]
        public ActionResult AddNewLog(LogSchedule model)
        {
            _c.AddNewLogSchedul(model);
            return View();
        }

        [HttpGet]
        public ViewResult ShowLogSchedule()
        {
            List<LogSchedule> newSl = _c.GetAllSL();
            List<ServiceLog> sl = new List<ServiceLog>();

            foreach (var item in newSl)
            {
                ServiceLog sl1 = new ServiceLog
                {
                    Reference = item.Reference,
                    Client_name = item.Client_name,
                    Start_date = item.Actual_start_date,
                    End_date = item.Actual_finish_date,
                    Service = item.Service_and_billing_note,
                    Status = "Draft",
                    SSID = item.ReferenceID
                };
                sl.Add(sl1);
            }
            return View(sl);
        }
        
        [HttpGet]
        public ViewResult UpdateSL(int id)
        {
            LogSchedule newSL = _c.GetSLByID(id);
            return View(newSL);
        }

        [HttpPost]
        public ActionResult UpdateSL(LogSchedule model)
        {
            _c.UpdateSL(model);
            return RedirectPermanent("/ServiceSchedules/ShowLogSchedule");
        }

        [Route("/LogSchedule/DeleteSL/{id:int}")]
        public ActionResult DeleteSL(int id)
        {
            _c.DeleteSL(id);
            return RedirectPermanent("/ServiceSchedules/ShowLogSchedule");
        }









        //-----------------------------Approved--------------------------------------//
        [HttpGet]
        public ActionResult ApprovedServiceLog(int id)
        {
            LogSchedule newSL = _c.GetLogDataByID(id);
            ApprovedTb approved = new ApprovedTb();

            approved.Reference = newSL.Reference;
            approved.Client_name = newSL.Client_name;
            approved.Start_date = newSL.Actual_start_date;
            approved.End_date = newSL.Actual_finish_date;
            approved.Service = newSL.Service_and_billing_note;
            approved.Status = "Draft";

            _c.InsertLogdata(approved);
            _c.DeleteSL(id);

            List<ApprovedTb> ap = _c.GetAll();
            return View(ap);
        }



        //-----------------------------Invoice-----------------------------//

        [HttpGet]
        public ViewResult Invoice(int id)
        {
            ApprovedTb ap = _c.GetApprovedDataByID(id);
            InvoiceTb In = new InvoiceTb();

            In.Reference = ap.Reference;
            In.Client_name = ap.Client_name;
            In.Start_date = ap.Start_date;
            In.End_date = ap.End_date;
            In.Service = ap.Service;
            In.Status = ap.Status;
            In.Cliam_number = ap.Reference;

            _c.InsertDataIntoInvoice(In);
            _c.DeleteIN(id);

            List<InvoiceTb> IN = _c.GetAllInvoiceData();
            return View(IN);
        }


    }
}