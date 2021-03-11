using Microsoft.EntityFrameworkCore;
using MVC_DynamicMenu.Data;
using MVC_DynamicMenu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_DynamicMenu.Repo
{
    public class InceientLogRepo
    {
        private readonly DynamicMenuDBContext _context;

        public InceientLogRepo(DynamicMenuDBContext context)
        {
            _context = context;
        }

        public void AddNewAccidentLog(IncidentLog incident)
        {
            var newIncident = new IncidentLog
            {
                Client = incident.Client,
                Unit = incident.Unit,
                EntryDate = incident.EntryDate,
                LastUpdate = incident.LastUpdate
            };

            _context.IncidentLog.Add(newIncident);
            _context.SaveChanges();
        }

       
    }


}
