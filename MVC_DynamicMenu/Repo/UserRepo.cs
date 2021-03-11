using Microsoft.EntityFrameworkCore;
using MVC_DynamicMenu.Data;
using MVC_DynamicMenu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_DynamicMenu.Repo
{
	public class UserRepo
	{
		private readonly DynamicMenuDBContext _context = null;

		public UserRepo(DynamicMenuDBContext context)
		{
			_context = context;
		}

		public void AddNewUser(Users model)
		{
			Roles rl = new Roles
			{
				RoleId = 0,
				RoleName = "Pending"
			};
			var NewUser = new Users
			{
				Name = model.Name,
				email = model.email,
				username = model.username,
				password = model.password,
				role = rl.RoleName,
				RoleId = rl.RoleId

			};
			_context.Users.AddAsync(NewUser);
			_context.SaveChanges();

		}

		public void AddNewMenu(List<Menus> model)
		{
			foreach (var item in model)
			{
				var NewUser = new Menus
				{
					Menu = item.Menu,
					Url = item.Url
				

				};
				_context.Menus.AddAsync(NewUser);
				
				
			}

			_context.SaveChanges();
		}

		public Users getUserById(int id)
		{
			var obj = _context.Users
			.FromSqlRaw("SELECT * FROM dbo.Users WHERE UserId=" + id)
			.ToList();

			return obj[0];
		}

		public Users getUserByUsername(string uname)
		{
			try
			{
				var obj = _context.Users
			.FromSqlRaw("SELECT * FROM dbo.Users WHERE username='" + uname + "'")
			.ToList();

				return obj[0];
			}
			catch (Exception)
			{

				return null;
			}
		}

			public void DeleteUser(int id)
			{
					var User = _context.Users.FirstOrDefault(x => x.UserId == id);
					if (User != null)
					{
						_context.Users.Remove(User);
						_context.SaveChanges();
					}
			}

		public List<Menus> getMenuById(int id)
		{
			try
			{
				var obj = _context.Menus
			.FromSqlRaw("SELECT * FROM dbo.Menus WHERE UserId=" + id)
			.ToList();

				return obj;


			}
			catch (Exception)
			{

				return null;
			}
		}

		public List<Users> getUsers()
        {
			var obj = _context.Users
				.FromSqlRaw("SELECT * FROM dbo.Users")
				.ToList();

			return obj;
        }

		public void UpdateUser(Users model)
        {
			var role = getrolebyID(model.RoleId);
			var userup = new Users
			{				
				UserId = model.UserId,
				email = model.email,
				Name = model.Name,
				password = model.password,
				role = role.RoleName,
				RoleId =role.RoleId,
				Roles = role,
				username = model.username
				
				
			};
			_context.Users.Update(userup);
			_context.SaveChanges();
        }

		//roles//////////////////////////////////////////////////////////////////
		public void CreateRole(Roles model)
		{
			_context.Roles.Add(model);
			_context.SaveChanges();
		}

		public List<RoleMenus> GetRoleMenus()
		{
			var obj = _context.RoleMenus
				.FromSqlRaw("SELECT * FROM dbo.RoleMenus").ToList();

			return obj;

		}



		public RoleMenus getrolemenubyID(int id)
		{
			var obj = _context.RoleMenus
				.FromSqlRaw("SELECT * FROM dbo.RoleMenus WHERE MenuId=" + id).ToList();

			return obj[0];
		}
		public Roles getrolebyID(int id)
		{
			var obj = _context.Roles
				.FromSqlRaw("SELECT * FROM dbo.Roles WHERE RoleId=" + id).ToList();

			return obj[0];
		}
		public void addNewRoleOptions(List<RoleOptions> model)
		{
			foreach (var item in model)
			{
				RoleOptions newroleop = new RoleOptions
				{
					Add = item.Add,
					addFolder = item.addFolder,
					Approve = item.Approve,
					Delete = item.Delete,
					Edit = item.Edit,
					EditFolder = item.EditFolder,
					RoleId = item.RoleId,
					View = item.View,
					RoleMenuId = item.RoleMenuId,
					RoleMenus = getrolemenubyID(item.RoleMenuId),
					Roles = getrolebyID(item.RoleId)
				};

				_context.RoleOptions.Add(newroleop);
				_context.SaveChanges();
			}
			
		}

		public List<RoleOptions> getallroleoptionsById(int ID)
		{
			var obj = _context.RoleOptions
				.FromSqlRaw("SELECT * FROM dbo.RoleOptions WHERE RoleId="+ID).ToList();

			return obj;
		}

		public List<Roles> getroles()
		{
			var obj = _context.Roles.FromSqlRaw("select * from dbo.Roles").ToList();
			return obj;
		}

		public void deleteRoleOp(int id)
		{
			_context.Database.ExecuteSqlRaw("DELETE FROM dbo.RoleOptions WHERE RoleId="+id);
		}
		public void InitRoleMenus()
		{
			List<RoleMenus> rm = new List<RoleMenus>();
			for (int i = 0; i < 32; i++)
			{
				var rmm = new RoleMenus
				{
					Menu = "",
					Url = ""
				};
				rm.Add(rmm);
			}
			rm[0].Menu = "Participent Data Entry";
			rm[0].Url = "#";

			rm[1].Menu = "Activity Log";
			rm[1].Url = "/Client/ActiveLogMain";

			rm[2].Menu = "Behaviour Log";
			rm[2].Url = "/NewBehaviorLog/BehaviourLog";

			rm[3].Menu = "Food And Fluid";
			rm[3].Url = "/AddNewFoodAndFluid/ShowAllFoodAndFluid";

			rm[4].Menu = "Incident Log";
			rm[4].Url = "/NewIncident/Incident";

			rm[5].Menu = "Mental Health Review Form";
			rm[5].Url = "/MentalHealthReview/ShowAllMHReviews";

			rm[6].Menu = "PSC 35";
			rm[6].Url = "/PSA35/ShowAllPSA35";

			rm[7].Menu = "Restrictive Practice Record";
			rm[7].Url = "/RestrictivePractice/ShowAllRestrctivePractices";

			rm[8].Menu = "Shift Log AM";
			rm[8].Url = "/ShiftLogAM/GetAllAddNewShiftLogAM";

			rm[9].Menu = "Shift Log PM";
			rm[9].Url = "/ShiftLogPM/GetAllAddNewShiftLogPM";

			rm[10].Menu = "Shift Log Night";
			rm[10].Url = "/ShiftLogNight/GetAllAddNewShiftLogNight";

			rm[11].Menu = "SLES Progress Note";
			rm[11].Url = "/SLES/ShowALLSLESProgresses";

			rm[12].Menu = "Support Coordination";
			rm[12].Url = "/SupportCoordination/ShowAllSupportCoordinations";

			rm[13].Menu = "Therapy Log";
			rm[13].Url = "/TherapyLog/ShowAllTL";


			rm[14].Menu = "Staff Data Entry";
			rm[14].Url = "#";

			rm[15].Menu = "Staff Meeting";
			rm[15].Url = "/StaffAndMeeting/GetAllSM";

			rm[16].Menu = "Unit Data Entry";
			rm[16].Url = "#";

			rm[17].Menu = "Emergency Fire Evacution Drill";
			rm[17].Url = "/EmergencyFireEvacutionDrill/ShowAllFD";

			rm[18].Menu = "Fortnightly Safety";
			rm[18].Url = "/NewFortnightlySafety/ShowAllFS";

			rm[19].Menu = "Medication";
			rm[19].Url = "#";

			rm[20].Menu = "Medication Plans";
			rm[20].Url = "/Medication/MedicationMain";

			rm[21].Menu = "Scheduling And Billing";
			rm[21].Url = "#";

			rm[22].Menu = "Budget Agreement";
			rm[22].Url = "/NewBudgetAgreement/ShowAllBA";

			rm[23].Menu = "Service Schedule";
			rm[23].Url = "/ServiceSchedules/ShowAllSS";

			rm[24].Menu = "Service Log";
			rm[24].Url = "/ServiceSchedules/ShowLogSchedule";

			rm[25].Menu = "Service Invoices";
			rm[25].Url = "/ServiceSchedules/Invoice";

			rm[26].Menu = "Participants";
			rm[26].Url = "/Patient_Contact/AddNewParticipant";

			rm[27].Menu = "Payment Requests";
			rm[27].Url = "/#";

			rm[28].Menu = "Admin";
			rm[28].Url = "#";

			rm[29].Menu = "Roles";
			rm[29].Url = "/Admin/GetRoles";

			rm[30].Menu = "Staff";
			rm[30].Url = "/Admin/Staff";

			rm[31].Menu = "Participant";
			rm[31].Url = "/Patient/ShowPatients";

			foreach (var item in rm)
			{
				_context.RoleMenus.Add(item);
				_context.SaveChanges();
			}
		}

	}
}
