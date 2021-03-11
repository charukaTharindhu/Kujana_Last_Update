using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC_DynamicMenu.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_DynamicMenu.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

		public ActionResult Index()
		{
			string str = HttpContext.Session.GetString("username");
			if (string.IsNullOrEmpty(str))
			{
				
				return RedirectPermanent("/UserPemission/Index");

			}
			else
			{
				return View();
			}

		}
		[HttpGet]
		public ActionResult Logmeout()
		{
			HttpContext.Session.Remove("menus");
			HttpContext.Session.Remove("username");
			HttpContext.Session.Remove("userRole");
			HttpContext.Session.Remove("userid");
			HttpContext.Session.Clear();

			foreach (var cookie in HttpContext.Request.Cookies.Keys)

			{
				if (cookie == ".AspNetCore.Session")
					HttpContext.Response.Cookies.Delete(cookie);
			}

			return RedirectPermanent("/UserPemission/Index");
		}
		public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
