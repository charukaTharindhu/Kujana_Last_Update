using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC_DynamicMenu.Models;
using MVC_DynamicMenu.Repo;
using MVC_DynamicMenu.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_DynamicMenu.Controllers
{
    public class ClientController : Controller
    {
        private readonly ClientRepo _clientRepo = null;
        private readonly IWebHostEnvironment hostingEnvironment;

        public ClientController(ClientRepo ClientRepo, IWebHostEnvironment HostingEnvironment)
        {
            _clientRepo = ClientRepo;
            hostingEnvironment = HostingEnvironment;
        }


        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ViewResult AddNewClient()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddNewClient(ClientView client)
        {
            string uniqeFileName = null;
            if (client.Attach != null)
            {
                string folder = Path.Combine(hostingEnvironment.WebRootPath, "ActivityDoc");
                uniqeFileName = Guid.NewGuid().ToString() + "_" + client.Attach.FileName;
                string filepath = Path.Combine(folder, uniqeFileName);
                using (var filestream = new FileStream(filepath, FileMode.Create))
                {
                    client.Attach.CopyTo(filestream);
                }
            }
            Client NewClinet = new Client
            {
                ActivityEndDate = client.ActivityEndDate,
                ActivityScheduled = client.ActivityScheduled,
                ActivityStartDate = client.ActivityStartDate,
                Activity_ModifyEachOrganisations = client.Activity_ModifyEachOrganisations,
                AM_Transport = client.AM_Transport,
                Attachments = uniqeFileName,
                ClientAttendend = client.ClientAttendend,
                Clients = client.Clients,
                DescribeOutcomes = client.DescribeOutcomes,
                EntryDate = client.EntryDate,
                Hierarchy = client.Hierarchy,
                IssuesAndFollowupRequired = client.IssuesAndFollowupRequired,
                Location = client.Location,
                PersonAttending = client.PersonAttending,
                PM_Transport = client.PM_Transport,
                PrimaryPurposeOfActivity = client.PrimaryPurposeOfActivity,
                SpecifyActivityPurpos = client.SpecifyActivityPurpos,
                StaffMemberName = client.StaffMemberName,
                TimeFrom = client.TimeFrom,
                TimeTo = client.TimeTo
            };
            _clientRepo.AddNewClient(NewClinet);
            return RedirectPermanent("/Client/ActiveLogMain");
        }

        public ViewResult ActiveLogMain()
        {
            HttpContext.Session.SetString("clients", _clientRepo.GetPatients());
            List<Client> clients = _clientRepo.getAllActiveLog();
            List<ActiveLogMain> activeLogMains = new List<ActiveLogMain>();

            foreach (var item in clients)
            {
                ActiveLogMain activeLogMains1 = new ActiveLogMain
                {
                    Client = item.Clients,
                    Entry_Date = item.EntryDate,
                    Last_Updated = item.EntryDate,
                    Reference = item.ClientID,
                    Unit = "Counceling"
                };
                activeLogMains.Add(activeLogMains1);
            }

            return View(activeLogMains);
        }
        [HttpGet]
        public ViewResult UpdateActivityLog(int id)
        {
            Client client = _clientRepo.getUserById(id);
            EditActivity NewClinet = new EditActivity
            {
                ClientID = client.ClientID,
                ActivityEndDate = client.ActivityEndDate,
                ActivityScheduled = client.ActivityScheduled,
                ActivityStartDate = client.ActivityStartDate,
                Activity_ModifyEachOrganisations = client.Activity_ModifyEachOrganisations,
                AM_Transport = client.AM_Transport,
                existingpath = client.Attachments,
                ClientAttendend = client.ClientAttendend,
                Clients = client.Clients,
                DescribeOutcomes = client.DescribeOutcomes,
                EntryDate = client.EntryDate,
                Hierarchy = client.Hierarchy,
                IssuesAndFollowupRequired = client.IssuesAndFollowupRequired,
                Location = client.Location,
                PersonAttending = client.PersonAttending,
                PM_Transport = client.PM_Transport,
                PrimaryPurposeOfActivity = client.PrimaryPurposeOfActivity,
                SpecifyActivityPurpos = client.SpecifyActivityPurpos,
                StaffMemberName = client.StaffMemberName,
                TimeFrom = client.TimeFrom,
                TimeTo = client.TimeTo
            };

            return View(NewClinet);
        }
        [HttpGet]
        public ViewResult ViewActivityLog(int id)
        {
            Client client = _clientRepo.getUserById(id);
            return View(client);
        }

        [Route("/Client/DeleteActivityLog/{id:int}")]
        public ActionResult DeleteActivityLog(int id)
        {
            var activitylog = _clientRepo.getUserById(id);
            if (activitylog.Attachments != null)
            {
                string oldpath = Path.Combine(hostingEnvironment.WebRootPath, "ActivityDoc", activitylog.Attachments);
                System.IO.File.Delete(oldpath);
            }
            _clientRepo.DeleteActiveLog(id);
            return RedirectPermanent("/Client/ActiveLogMain");
        }

        [HttpPost]
        public ActionResult UpdateActivityLog(EditActivity model)
        {
            string uniqeFileName = null;
            if (model.Attach != null)
            {
                if (model.existingpath != null)
                {
                    string oldpath = Path.Combine(hostingEnvironment.WebRootPath, "ActivityDoc", model.existingpath);
                    System.IO.File.Delete(oldpath);
                }
                string folder = Path.Combine(hostingEnvironment.WebRootPath, "ActivityDoc");
                uniqeFileName = Guid.NewGuid().ToString() + "_" + model.Attach.FileName;
                string filepath = Path.Combine(folder, uniqeFileName);
                using (var filestream = new FileStream(filepath, FileMode.Create))
                {
                    model.Attach.CopyTo(filestream);
                }

            }
            Client NewClinet = new Client
            {
                ClientID = model.ClientID,
                ActivityEndDate = model.ActivityEndDate,
                ActivityScheduled = model.ActivityScheduled,
                ActivityStartDate = model.ActivityStartDate,
                Activity_ModifyEachOrganisations = model.Activity_ModifyEachOrganisations,
                AM_Transport = model.AM_Transport,
                Attachments = uniqeFileName,
                ClientAttendend = model.ClientAttendend,
                Clients = model.Clients,
                DescribeOutcomes = model.DescribeOutcomes,
                EntryDate = model.EntryDate,
                Hierarchy = model.Hierarchy,
                IssuesAndFollowupRequired = model.IssuesAndFollowupRequired,
                Location = model.Location,
                PersonAttending = model.PersonAttending,
                PM_Transport = model.PM_Transport,
                PrimaryPurposeOfActivity = model.PrimaryPurposeOfActivity,
                SpecifyActivityPurpos = model.SpecifyActivityPurpos,
                StaffMemberName = model.StaffMemberName,
                TimeFrom = model.TimeFrom,
                TimeTo = model.TimeTo
            };
            _clientRepo.UpdateActivityLog(NewClinet);
            return RedirectPermanent("/Client/ActiveLogMain");
        }

    }
}
