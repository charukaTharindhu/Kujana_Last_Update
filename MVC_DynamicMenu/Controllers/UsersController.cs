using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC_DynamicMenu.Models;
using MVC_DynamicMenu.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_DynamicMenu.Controllers
{
	public class UsersController : Controller
	{
		private readonly UserRepo _userRepo = null;

		public UsersController(UserRepo UserRepo)
		{
			_userRepo = UserRepo;
		}
		public IActionResult Index()
		{
			return View();
		}
		public ViewResult AddUser()
		{

			return View();
		}

		[HttpPost]
		public ActionResult AddUser(Users model)
		{
			 _userRepo.AddNewUser(model);
			var a = _userRepo.getUserByUsername(model.username);
			return RedirectPermanent("/");
		
		}
	

		

		public ViewResult ShowUsers()
        {
			List<Users> us = _userRepo.getUsers();
			return View(us);
        }





	}
}
