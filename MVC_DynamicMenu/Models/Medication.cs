using FSharp.Data.Runtime.StructuralTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_DynamicMenu.Models
{
	public class Medication
	{
		[Key]
		public int MedicationId { get; set; }

		public string Client { get; set; }
		public string StartDate { get; set; }
		public string EndDate { get; set; }
		public string Name { get; set; }
		public string Dosage { get; set; }
		public string route { get; set; }
		public string timing { get; set; }
		public string frequency { get; set; }
		public string prescribed_by { get; set; }
		public string status { get; set; }
		public int clientId { get; set; }
	}
}
