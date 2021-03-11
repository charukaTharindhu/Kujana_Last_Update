using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC_DynamicMenu.Models;
using MVC_DynamicMenu.Repo;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_DynamicMenu.Controllers
{
	public class AdminController : Controller
	{
		private readonly UserRepo _userRepo = null;

		public AdminController(UserRepo UserRepo)
		{
			_userRepo = UserRepo;
		}
		public IActionResult Staff()
		{
			var users= _userRepo.getUsers();
			return View(users);
		}
		
		[HttpGet]
		public ActionResult UpdateUser(int id)
		{
			Users us = _userRepo.getUserById(id);
			ViewBag.Roles = _userRepo.getroles();
			return View(us);
		}

		[HttpGet]
		public ActionResult DeleteUser(int id)
		{
			_userRepo.DeleteUser(id);
			return RedirectPermanent("/Admin/Staff/");

		}


		[HttpPost]
		public ActionResult UpdateUser(Users model)
		{
			_userRepo.UpdateUser(model);
			
			return RedirectPermanent("/Admin/Staff/");
		}

		[HttpGet]
		public ActionResult CreateRole()
		{
			return View();
		}
		[HttpPost]
		public ActionResult CreateRole(Roles model)
		{
			_userRepo.CreateRole(model);
			var crole = JsonConvert.SerializeObject(model);
			HttpContext.Session.SetString("createdRole", crole);
			return RedirectPermanent("/Admin/AddRoleOptions");
		}

		[HttpGet]
		public ActionResult AddRoleOptions()
		{
			Roles crole = JsonConvert.DeserializeObject<Roles>(HttpContext.Session.GetString("createdRole"));
			var dat = _userRepo.GetRoleMenus();
			ViewBag.menus = dat;
			ViewBag.role = crole;
			return View();
		}

		[HttpPost]
		public IActionResult AddRoleOptions(List<RoleOptions> model)
		{
			_userRepo.addNewRoleOptions(model);
			var user = _userRepo.getUserByUsername(HttpContext.Session.GetString("userid"));
			return RedirectPermanent("/UserPermission/setSession/id="+user);
		}

		[HttpGet]
		public ActionResult GetRoles()
		{
			var obj = _userRepo.getroles();
			return View(obj);
		}

		[Route("/Admin/EditRole/{id:int}")]
		[HttpGet]
		public ActionResult EditRole(int id)
		{
			var dat = _userRepo.GetRoleMenus();
			var obj = _userRepo.getallroleoptionsById(id);
			var role = _userRepo.getrolebyID(id);
			if (obj.Count>0)
			{
				ViewBag.menus = dat;
				ViewBag.role = role;
				return View(obj);
			}
			else
			{
				var crole = new Roles { 
				RoleId = role.RoleId,
				RoleName = role.RoleName
				};
				var rolecon = JsonConvert.SerializeObject(crole);
				HttpContext.Session.SetString("createdRole", rolecon);
				return RedirectPermanent("/Admin/AddRoleOptions");
			}
		}
		[HttpPost]
		public ActionResult EditRole(List<RoleOptions> model)
		{
			_userRepo.deleteRoleOp(model[0].RoleId);
			_userRepo.addNewRoleOptions(model);
			return RedirectPermanent("/Admin/GetRoles");
		}
		}
}
