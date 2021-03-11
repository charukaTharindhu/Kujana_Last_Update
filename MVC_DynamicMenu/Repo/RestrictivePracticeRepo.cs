using MVC_DynamicMenu.Data;
using MVC_DynamicMenu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_DynamicMenu.Repo
{
    public class RestrictivePracticeRepo
    {
        private readonly DynamicMenuDBContext _context;

        public RestrictivePracticeRepo(DynamicMenuDBContext context)
        {
            _context = context;
        }

        public void RestrictivePracticeRcord(RestrictivePracticeRecord rp)
        {
            var newRP = new RestrictivePracticeRecord
            {
                Reference = rp.Reference,
                Client = rp.Client,
                Unit = rp.Unit,
                EntryDate = rp.EntryDate,
                LastUpdate = rp.LastUpdate
            };
            _context.RestrictivePracticeRecord.Add(newRP);
            _context.SaveChanges();
        }
    }
}
