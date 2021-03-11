using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_DynamicMenu.Models
{
	public class RoleOptions
	{
		[Key]
		public int Id { get; set; }
		public int Add { get; set; }
		public int Edit { get; set; }
		public int Delete { get; set; }
		public int View { get; set; }
		public int Approve { get; set; }
		public int addFolder { get; set; }
		public int EditFolder { get; set; }

		public int RoleMenuId { get; set; }
		public RoleMenus RoleMenus { get; set; }

		public int RoleId { get; set; }
		public Roles Roles { get; set; }

	}
}
