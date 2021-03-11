using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_DynamicMenu.Data;
using MVC_DynamicMenu.Models;
using MVC_DynamicMenu.Repo;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MVC_DynamicMenu.Controllers
{
	public class UserPemissionController : Controller
	{
		private readonly UserRepo _userRepo = null;

		public UserPemissionController(UserRepo UserRepo)
		{
			_userRepo = UserRepo;
		}

		[HttpGet]
		public ActionResult Index()
		{
			foreach (var cookie in HttpContext.Request.Cookies.Keys)

			{
				if (cookie == ".AspNetCore.Session")
					HttpContext.Response.Cookies.Delete(cookie);
			}
			string str = HttpContext.Session.GetString("username");
			if (string.IsNullOrEmpty(str))
			{

				return View();

			}
			else
			{

				return RedirectPermanent("/Home/Index");
			}


		}

		[HttpPost]
		public ActionResult Index(Users model)
		{

			Users newUser = _userRepo.getUserByUsername(model.username.Trim());
			if (newUser == null||newUser.role.Trim().Equals("Pending"))
			{
				ModelState.AddModelError(string.Empty, "Invalid Login");
				return View(model);
			}
			else
			{
				if (model.password.Trim() == newUser.password.Trim())
				{

					setSession(newUser.UserId);

					return RedirectPermanent("/Home/Index");
				}
			}
			return View();

		}
		public void setSession(int id)
		{
			var newUser = _userRepo.getUserById(id);
			HttpContext.Session.SetString("username", newUser.username);
			HttpContext.Session.SetString("roleid", newUser.RoleId.ToString());
			var role = _userRepo.getrolebyID(newUser.RoleId);
			HttpContext.Session.SetString("userRole", role.RoleName);
			HttpContext.Session.SetString("userid", newUser.UserId.ToString());
			List<RoleOptions> ro = _userRepo.getallroleoptionsById(newUser.RoleId);
			List<OnlyMenu> om = new List<OnlyMenu>();
			for (int i = 0; i < ro.Count; i++)
			{
				if (ro[i].View == 1)
				{
					RoleMenus rm = _userRepo.getrolemenubyID(ro[i].RoleMenuId);
					OnlyMenu newMenu = new OnlyMenu
					{
						Menu = rm.Menu,
						Url = rm.Url
					};

					om.Add(newMenu);
				}
			}
			var str = JsonConvert.SerializeObject(om);
			HttpContext.Session.SetString("menus", str);
			
		}


		
    }
}

