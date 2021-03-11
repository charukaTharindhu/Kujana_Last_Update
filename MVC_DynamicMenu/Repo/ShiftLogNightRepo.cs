using MVC_DynamicMenu.Data;
using MVC_DynamicMenu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_DynamicMenu.Repo
{
    public class ShiftLogNightRepo
    {
        private readonly DynamicMenuDBContext _context;

        public ShiftLogNightRepo(DynamicMenuDBContext context)
        {
            _context = context;
        }

        public void ShiftLogNight(ShiftLogNight SLNight)
        {
            var newSLNight = new ShiftLogNight
            {
                Reference = SLNight.Reference,
                Client = SLNight.Client,
                Unit = SLNight.Unit,
                EntryDate = SLNight.EntryDate,
                LastUpdate = SLNight.LastUpdate
            };

            _context.ShiftLogNight.Add(newSLNight);
            _context.SaveChanges();
        }

    }
}
