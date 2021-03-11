using MVC_DynamicMenu.Data;
using MVC_DynamicMenu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_DynamicMenu.Repo
{
	public class BehaviorLogRepo
	{
		private readonly DynamicMenuDBContext _context = null;

		public BehaviorLogRepo(DynamicMenuDBContext context)
		{
			_context = context;
		}

		public void AddNewBehaviorLog(BehaviorLog Blog)
		{
			var NewLog = new BehaviorLog
			{
				Reference = Blog.Reference,
				Client = Blog.Client,
				Unit = Blog.Unit,
				Entry_Date = Blog.Entry_Date,
				Last_Updated = Blog.Last_Updated
			};
			_context.BehaviorLog.Add(Blog);
			_context.SaveChanges();

		}
	}
}
