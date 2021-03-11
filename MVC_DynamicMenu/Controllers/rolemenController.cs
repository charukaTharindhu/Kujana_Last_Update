using Microsoft.AspNetCore.Mvc;
using MVC_DynamicMenu.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_DynamicMenu.Controllers
{
	public class rolemenController : Controller
	{
		private readonly UserRepo _userRepo = null;

		public rolemenController(UserRepo userRepo)
		{
			_userRepo = userRepo;
		}
		[HttpGet]
		public IActionResult Index()
		{
			_userRepo.InitRoleMenus();
			return RedirectPermanent("/");
		}
	}
}
