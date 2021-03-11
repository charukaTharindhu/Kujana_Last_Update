using MVC_DynamicMenu.Data;
using MVC_DynamicMenu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_DynamicMenu.Repo
{
    public class ShiftLogPMRepo
    {
        private readonly DynamicMenuDBContext _context;

        public ShiftLogPMRepo(DynamicMenuDBContext context)
        {
            _context = context;
        }

        public void ShiftLogPM(ShiftLogPM SLPM)
        {
            var newSLPM = new ShiftLogPM
            {
                Reference = SLPM.Reference,
                Client = SLPM.Client,
                Unit = SLPM.Unit,
                EntryDate = SLPM.EntryDate,
                LastUpdate = SLPM.LastUpdate
            };

            _context.ShiftLogPM.Add(newSLPM);
            _context.SaveChanges();
        }

    }
}
