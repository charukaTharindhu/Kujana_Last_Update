using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_DynamicMenu.Models
{
	public class Medication_main
	{
		[Key]
		public int Id { get; set; }
		public int ClientId { get; set; }
		public string FullName { get; set; }
		public int ApprovedPlans { get; set; }
		public int PendingPlans { get; set; }
	}
}
