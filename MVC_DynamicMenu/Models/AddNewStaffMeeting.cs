using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_DynamicMenu.Models
{
    public class AddNewStaffMeeting
    {
        [Key]
        public int Reference { get; set; }
        public String Client_Name { get; set; }
        public String Entry_Date { get; set; }
        public String Hierarchy { get; set; }
        public String Date_and_Time { get; set; }
        public String Time { get; set; }
        public String Next_Meeting_Date_and_Time { get; set; }
        public String Next_Meeting_Time { get; set; }
        public String Attendence { get; set; }
        public String Apologies { get; set; }
        public String Chairperson { get; set; }
        public String Minute_Taker { get; set; }
        public String Standing_agenda_Items { get; set; }
        public String Actions_From_Previous_minutes { get; set; }
        public String Good_news_stories { get; set; }
        public String NDIS_Goals { get; set; }
        public String New_Activities_or_experience_to_share { get; set; }
        public String Health_concerms { get; set; }
        public String Upcomin_Appointments { get; set; }
        public String Incident_Reports { get; set; }
        public String Changes_In_Behaviour { get; set; }
        public String Training_Oppotunities { get; set; }
        public String CIARS_Recording { get; set; }
        public String Any_WH_and_S_issues_to_reported { get; set; }
        public String House_mainteance { get; set; }
        public String The_policy_reviewed_during_the_meeting_and_discussion { get; set; }
        public String Staff_Discussion { get; set; }
        public String What_does_the_team_needs_to_follow_up { get; set; }
        public String What_deos_the_coordinator_needs_to_follow_up { get; set; }
        public String Staff_Member_Name { get; set; }
 
    }
}
