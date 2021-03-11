using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_DynamicMenu.Models
{
	public class RoleMenus
	{
		[Key]
		public int MenuId { get; set; }
		public string Menu { get; set; }
		public string Url { get; set; }

		public List<RoleOptions> roleOptions { get; set; }
	}
}
