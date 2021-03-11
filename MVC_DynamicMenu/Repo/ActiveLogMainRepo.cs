using Microsoft.EntityFrameworkCore;
using MVC_DynamicMenu.Data;
using MVC_DynamicMenu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_DynamicMenu.Repo
{
	public class ActiveLogMainRepo
	{
		private readonly DynamicMenuDBContext _context = null;

		public ActiveLogMainRepo(DynamicMenuDBContext context)
		{
			_context = context;
		}

		public void AddNewActiveLog(ActiveLogMain log)
		{
			var NewLog = new ActiveLogMain
			{
				Reference = log.Reference,
				Client = log.Client,
				Unit = log.Unit,
				Entry_Date = log.Entry_Date,
				Last_Updated = log.Last_Updated
			};
			_context.ActiveLogMain.Add(log);
			_context.SaveChanges();

		}

		public List<ActiveLogMain> getAllActiveLog()
		{
			var obj = _context.ActiveLogMain
			.FromSqlRaw("SELECT * FROM dbo.ActiveLogMain")
			.ToList();

			return obj;
		}
	}
}
