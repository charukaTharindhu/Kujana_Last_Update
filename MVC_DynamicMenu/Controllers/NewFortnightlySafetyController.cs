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
    public class NewFortnightlySafetyController : Controller
    {
        private readonly NewFortnightlySafetyRepo _c = null;

        public NewFortnightlySafetyController(NewFortnightlySafetyRepo c)
        {
            _c = c;
        }
        public IActionResult Index()
        {
            return View();
        }
        
        public ViewResult AddNewFS()
        {
            return View();
        }
        [HttpPost]
        public ViewResult AddNewFS(NewFortnightlySafety FS)
        {
            _c.AddNewFS(FS);
            return View();
        }

        public ViewResult ShowAllFS()
        {
            HttpContext.Session.SetString("safty", _c.GetPatients());
            List<NewFortnightlySafety> FS = _c.getAllFortnightlySafety();
            List<Fortnighttly> newfs = new List<Fortnighttly>();

            foreach (var item in FS)
            {
                Fortnighttly newfs1 = new Fortnighttly
                {
                    Reference = item.Reference,
                    Entry_Date = item.Entry_date,
                    Last_Updated = item.Entry_date,
                    Unit = "Coundseling"
                };

                newfs.Add(newfs1);
            }
            return View(newfs);
        }

        [HttpGet]
        public ViewResult UpdateFS(int id)
        {
            NewFortnightlySafety fs = _c.getFSByID(id);
            return View(fs);
        }

        [HttpGet]
        public ViewResult ViewFS(int id)
        {
            NewFortnightlySafety fs = _c.getFSByID(id);
            return View(fs);
        }

        [HttpPost]
        public ActionResult UpdateFS(NewFortnightlySafety model)
        {
            _c.UpdateFS(model);
            return RedirectPermanent("");
        }

        [Route("/NewFortnightlySafety/DeleteFS/{id:int}")]
        public ActionResult DeleteFS(int id)
        {
            _c.DeleteFS(id);
            return RedirectPermanent("");
        }
    }
}
