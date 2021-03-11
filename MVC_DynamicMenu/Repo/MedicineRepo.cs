using Microsoft.EntityFrameworkCore;
using MVC_DynamicMenu.Data;
using MVC_DynamicMenu.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_DynamicMenu.Repo
{
	public class MedicineRepo
	{
		private readonly DynamicMenuDBContext _context = null;

		public MedicineRepo(DynamicMenuDBContext context)
		{
			_context = context;
		}

		public void AddNewMed(Medication model)
		{
			var NewMedicine = new Medication
			{
				Client = model.Client,
				clientId = getPatientbyname(model.Client),
				Dosage = model.Dosage,
				EndDate = model.EndDate,
				frequency = model.frequency,
				Name = model.Name,
				prescribed_by = model.prescribed_by,
				route = model.route,
				StartDate = model.StartDate,
				status = "Pending",
				timing = model.timing
			};
			_context.Medication.AddAsync(NewMedicine);
			_context.SaveChanges();
			UpdateMainTable(NewMedicine.clientId);


		}

		public int getPatientbyname(string id)
		{

			var obj = _context.Patient.FromSqlRaw("SELECT * FROM dbo.Patient WHERE Full_Name='" + id + "'").ToList();
			return obj[0].PatientID;
		}

		public void UpdateMainTable(int id)
		{
			int approved = 0;
			int pending = 0;
			var med = _context.Medication
				.FromSqlRaw("SELECT * FROM dbo.Medication WHERE clientId=" + id)
			.ToList();
			_context.Database.ExecuteSqlRaw("DELETE FROM dbo.Medication_main WHERE ClientId=" + id);
			//search by client id and get details of the client
			var client = _context.Patient.FromSqlRaw("SELECT * FROM dbo.Patient WHERE PatientID=" + id).ToList();
			//////////////////////////
			foreach (var item in med)
			{
				if (item.status.Equals("Approved"))
				{
					approved = approved + 1;
				}
				if (item.status.Equals("Pending"))
				{
					pending = pending + 1;
				}
			}
			Medication_main mm = new Medication_main
			{
				ClientId = id,
				//set the client name below
				FullName = client[0].Full_Name,
				ApprovedPlans = approved,
				PendingPlans = pending
			};
			_context.Medication_main.Add(mm);
			_context.SaveChanges();
		}

		public List<Medication_main> getMedicationMain()
		{
			var med = _context.Medication_main
				.FromSqlRaw("SELECT * FROM dbo.Medication_main")
			.ToList();
			return med;
		}

		public void approvemed(int id)
		{
			var obj = _context.Medication.FromSqlRaw("SELECT * FROM dbo.Medication WHERE MedicationId=" + id).ToList();
			obj[0].status = "Approved";
			_context.Medication.Update(obj[0]);
			UpdateMainTable(obj[0].clientId);
			_context.SaveChanges();
		}

		public List<Medication> getMedicationbyId(int id)
		{
			var med = _context.Medication
				.FromSqlRaw("SELECT * FROM dbo.Medication WHERE clientId=" + id)
			.ToList();
			return med;
		}
		public Medication getMedicationplanId(int id)
		{
			var med = _context.Medication
				.FromSqlRaw("SELECT * FROM dbo.Medication WHERE MedicationId=" + id)
			.ToList();
			return med[0];
		}

		public void updatemed(Medication model)
		{
			var obj = _context.Medication.FromSqlRaw("SELECT * FROM dbo.Medication WHERE MedicationId=" + model.MedicationId).ToList();
			obj[0].status = "Pending";
			obj[0].Name = model.Name;
			obj[0].Dosage = model.Dosage;
			obj[0].EndDate = model.EndDate;
			obj[0].frequency = model.frequency;
			obj[0].prescribed_by = model.prescribed_by;
			obj[0].route = model.route;
			obj[0].StartDate = model.StartDate;
			obj[0].timing = model.timing;

			_context.Medication.Update(obj[0]);
			UpdateMainTable(obj[0].clientId);
			_context.SaveChanges();
		}

		public string GetPatients()
		{
			var obj = _context.Patient.FromSqlRaw("SELECT * FROM dbo.Patient").ToList();
			var patients = JsonConvert.SerializeObject(obj);
			return patients;
		}

	}
}
