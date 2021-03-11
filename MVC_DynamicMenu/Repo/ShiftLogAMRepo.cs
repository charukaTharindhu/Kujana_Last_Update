using MVC_DynamicMenu.Data;
using MVC_DynamicMenu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_DynamicMenu.Repo
{
    public class ShiftLogAMRepo
    {
        private readonly DynamicMenuDBContext _context;

        public ShiftLogAMRepo(DynamicMenuDBContext context)
        {
            _context = context;
        }

        public void ShiftLogAM(ShiftLogAM SLAM)
        {
            var newSLAM = new ShiftLogAM
            {
                Reference = SLAM.Reference,
                Client = SLAM.Client,
                Unit = SLAM.Unit,
                EntryDate = SLAM.EntryDate,
                LastUpdate = SLAM.LastUpdate
            };

            _context.ShiftLogAM.Add(newSLAM);
            _context.SaveChanges();
        }

    }
}
