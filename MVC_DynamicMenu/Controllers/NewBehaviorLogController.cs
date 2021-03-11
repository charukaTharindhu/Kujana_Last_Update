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
    public class NewBehaviorLogController : Controller
    {
        private readonly NewBehaviorLogRepo _BehaviorRepo = null;

        public NewBehaviorLogController(NewBehaviorLogRepo behaviorRepo)
        {
            _BehaviorRepo = behaviorRepo;
        }
        public IActionResult BehaviourLog()
        {
            HttpContext.Session.SetString("behaviours", _BehaviorRepo.GetPatient());
            List<NewBehaviorLog> NewB = _BehaviorRepo.getAllBehaviourLog();
            List<BehaviorLog> behavior = new List<BehaviorLog>();

            foreach (var item in NewB)
            {
                BehaviorLog behaviorLog = new BehaviorLog
                {
                    Client = item.Client,
                    Entry_Date = item.EntryDate,
                    Last_Updated = item.EntryDate,
                    Reference = item.BehaviorID,
                    Unit = "Counseling"
                };
                behavior.Add(behaviorLog);

            }
            return View(behavior);

        }

        [HttpGet]
        public ActionResult AddNewBehavior()
        {
            return View();
        }

        [HttpPost]
        public ViewResult AddNewBehavior(NewBehaviorLog behaviorLog)
        {
            _BehaviorRepo.AddNewBehavior(behaviorLog);
            return View();
        }

        public ViewResult getAllBehaviourLog()
        {
            List<NewBehaviorLog> NewB = _BehaviorRepo.getAllBehaviourLog();
            List<BehaviorLog> behavior = new List<BehaviorLog>();

            foreach (var item in NewB)
            {
                BehaviorLog behaviorLog = new BehaviorLog
                {
                    Client = item.Client,
                    Entry_Date = item.EntryDate,
                    Last_Updated = item.EntryDate,
                    Reference = item.BehaviorID,
                    Unit = "Counseling"
                };
                behavior.Add(behaviorLog);

            }
            return View(behavior);
        }
        [HttpGet]
        public ViewResult UpdateBehaviourLog(int id)
        {
            NewBehaviorLog behaviour = _BehaviorRepo.getUserById(id);
            return View(behaviour);
        }

        [HttpGet]
        public ViewResult ViewBehaviourLog(int id)
        {
            NewBehaviorLog behaviour = _BehaviorRepo.getUserById(id);
            return View(behaviour);
        }

        [Route("/NewBehaviour/DeleteBehaviour/{id:int}")]
        public ActionResult DeleteBehaviour(int id)
        {
            _BehaviorRepo.DeleteBehaviour(id);
            return RedirectPermanent("/NewBehaviorLog/BehaviourLog");

        }


        [HttpPost]
        public ActionResult UpdateBehaviourLog(NewBehaviorLog model)
        {
            _BehaviorRepo.UpdateBehaviourLog(model);
            return RedirectPermanent("/NewBehaviorLog/BehaviourLog");
        }
    }
}
