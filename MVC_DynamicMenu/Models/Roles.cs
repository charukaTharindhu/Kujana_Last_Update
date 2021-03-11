using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_DynamicMenu.Models
{
	public class Roles
	{
		[Key]
		public int RoleId { get; set; }
		public string RoleName { get; set; }

		public List<Users> users { get; set; }
		public List<RoleOptions> roleOptions { get; set; }
	}
}
