using MVC_DynamicMenu.Data;
using MVC_DynamicMenu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_DynamicMenu.Repo
{
    public class SupportCoordinationRepo
    {
        private readonly DynamicMenuDBContext _context = null;

        public SupportCoordinationRepo(DynamicMenuDBContext context)
        {
            _context = context;
        }

        public void InsertSuportCoordination(SupporCoordination Sp)
        {
            var newSupport = new SupporCoordination
            {
                Reference = Sp.Reference,
                Client = Sp.Client,
                Unit = Sp.Unit,
                EntryDate = Sp.EntryDate,
                LastUpdate = Sp.LastUpdate
            };

            _context.SupporCoordination.Add(newSupport);
            _context.SaveChanges();
        }
    }

}
