using MVC_DynamicMenu.Data;
using MVC_DynamicMenu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_DynamicMenu.Repo
{
    public class SLESProgressRepo
    {
        private readonly DynamicMenuDBContext _context;

        public SLESProgressRepo(DynamicMenuDBContext context)
        {
            _context = context;
        }

        public void newSLESProgress(SLESProgress SLES)
        {
            var NewSLES = new SLESProgress
            {
                Client = SLES.Client,
                Unit = SLES.Unit,
                EntryDate = SLES.EntryDate,
                LastUpdate = SLES.LastUpdate
            };
            _context.SLESProgress.Add(NewSLES);
            _context.SaveChanges();
        }
    }
}
   