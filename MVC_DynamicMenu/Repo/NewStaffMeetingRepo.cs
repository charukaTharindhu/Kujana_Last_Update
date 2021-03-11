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
    public class NewStaffMeetingRepo
    {
        private readonly DynamicMenuDBContext _c = null;

        public NewStaffMeetingRepo(DynamicMenuDBContext c)
        {
            _c = c;
        }

        public void AddNewStaffMeeting(AddNewStaffMeeting model)
        {
            var newSM = new AddNewStaffMeeting
            {
                Reference = model.Reference,
                Client_Name = model.Client_Name,
                Entry_Date = model.Entry_Date,
                Hierarchy = model.Hierarchy,
                Actions_From_Previous_minutes = model.Actions_From_Previous_minutes,
                Any_WH_and_S_issues_to_reported = model.Any_WH_and_S_issues_to_reported,
                Apologies = model.Apologies,
                Attendence = model.Attendence,
                Chairperson = model.Chairperson,
                Changes_In_Behaviour = model.Changes_In_Behaviour,
                CIARS_Recording = model.CIARS_Recording,
                New_Activities_or_experience_to_share = model.New_Activities_or_experience_to_share,
                Date_and_Time = model.Date_and_Time,
                Good_news_stories = model.Good_news_stories,
                Health_concerms = model.Health_concerms,
                House_mainteance = model.House_mainteance,
                Incident_Reports = model.Incident_Reports,
                Minute_Taker = model.Minute_Taker,
                NDIS_Goals = model.NDIS_Goals,
                Next_Meeting_Date_and_Time = model.Next_Meeting_Date_and_Time,
                Next_Meeting_Time = model.Next_Meeting_Time,
                Staff_Discussion = model.Staff_Discussion,
                Staff_Member_Name = model.Staff_Member_Name,
                Standing_agenda_Items =model.Standing_agenda_Items,
                The_policy_reviewed_during_the_meeting_and_discussion = model.The_policy_reviewed_during_the_meeting_and_discussion,
                Time = model.Time,
                Training_Oppotunities = model.Training_Oppotunities,
                Upcomin_Appointments = model.Upcomin_Appointments,
                What_deos_the_coordinator_needs_to_follow_up = model.What_deos_the_coordinator_needs_to_follow_up,
                What_does_the_team_needs_to_follow_up = model.What_does_the_team_needs_to_follow_up
      
            };
            _c.AddNewStaffMeeting.Add(newSM);
            _c.SaveChanges();
        }

        public List<AddNewStaffMeeting> getAllSM()
        {
            var obj = _c.AddNewStaffMeeting.FromSqlRaw("Select * from dbo.AddNewStaffMeeting").ToList();
            return obj;
        }

        public AddNewStaffMeeting GetSMByID(int id)
        {
            var obj = _c.AddNewStaffMeeting
                .FromSqlRaw("Select * from dbo.AddNewStaffMeeting where Reference =" + id)
                .ToList();

            return obj[0];
        }

        public void UpdateSM(AddNewStaffMeeting model)
        {
            _c.AddNewStaffMeeting.Update(model);
            _c.SaveChanges();
        }

        public void DeleteSM(int id)
        {
            var SM = _c.AddNewStaffMeeting.FirstOrDefault(x => x.Reference == id);
            if (SM != null)
            {
                _c.AddNewStaffMeeting.Remove(SM);
                _c.SaveChanges();
            }
        }

        public string GetPatients()
        {
            var obj = _c.Patient.FromSqlRaw("SELECT * FROM dbo.Patient").ToList();
            var patients = JsonConvert.SerializeObject(obj);
            return patients;
        }
    }
}
