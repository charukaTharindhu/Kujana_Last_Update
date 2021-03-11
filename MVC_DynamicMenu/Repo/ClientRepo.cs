using Microsoft.AspNetCore.Http;
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
	public class ClientRepo
	{
		private readonly DynamicMenuDBContext _context = null;

		public ClientRepo(DynamicMenuDBContext context)
		{
			_context = context;
		}

		public void AddNewClient(Client model)
		{
			var NewClient = new Client
			{
				Clients = model.Clients,
				EntryDate = model.EntryDate,
				Hierarchy = model.Hierarchy,
				AM_Transport = model.AM_Transport,
				PM_Transport = model.PM_Transport,
				ActivityStartDate = model.ActivityStartDate,
				TimeFrom = model.TimeFrom,
				ActivityEndDate = model.ActivityEndDate,
				TimeTo = model.TimeTo,
				Location = model.Location,
				PersonAttending = model.PersonAttending,
				ActivityScheduled = model.ActivityScheduled,
				ClientAttendend = model.ClientAttendend,
				PrimaryPurposeOfActivity = model.PrimaryPurposeOfActivity,
				Activity_ModifyEachOrganisations = model.Activity_ModifyEachOrganisations,
				SpecifyActivityPurpos = model.SpecifyActivityPurpos,
				DescribeOutcomes = model.DescribeOutcomes,
				IssuesAndFollowupRequired = model.IssuesAndFollowupRequired,
				Attachments = model.Attachments,
				StaffMemberName = model.StaffMemberName
			};
			_context.Client.Add(NewClient);
			_context.SaveChanges();
		}

		public List<Client> getAllActiveLog()
		{
			var obj = _context.Client
			.FromSqlRaw("SELECT * FROM dbo.Client")
			.ToList();

			return obj;
		}
		public Client getUserById(int id)
		{
			var obj = _context.Client
			.FromSqlRaw("SELECT * FROM dbo.Client WHERE ClientID=" + id)
			.ToList();

			return obj[0];
		}
		public void UpdateActivityLog(Client model)
		{
			_context.Client.Update(model);
			_context.SaveChanges();
		}

		public void DeleteActiveLog(int id)
		{
			var client = _context.Client.FirstOrDefault(x => x.ClientID == id);
			if (client != null)
			{
				_context.Client.Remove(client);
				_context.SaveChanges();
			}
		}

		public string GetPatients()
		{
			var obj = _context.Patient.FromSqlRaw("SELECT * FROM dbo.Patient").ToList();
			var patients = JsonConvert.SerializeObject(obj);
			return patients;
		}

	}
}
