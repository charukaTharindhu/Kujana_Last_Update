using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_DynamicMenu.Models
{
    public class ClientView
    {
        [Key]
        public int ClientID { get; set; }
        public String Clients { get; set; }
        public String EntryDate { get; set; }
        public String Hierarchy { get; set; }
        public String AM_Transport { get; set; }
        public String PM_Transport { get; set; }
        public String ActivityStartDate { get; set; }
        public String TimeFrom { get; set; }
        public String ActivityEndDate { get; set; }
        public String TimeTo { get; set; }
        public String Location { get; set; }
        public String PersonAttending { get; set; }
        public String ActivityScheduled { get; set; }
        public String ClientAttendend { get; set; }
        public String PrimaryPurposeOfActivity { get; set; }
        public String Activity_ModifyEachOrganisations { get; set; }
        public String SpecifyActivityPurpos { get; set; }
        public String DescribeOutcomes { get; set; }
        public String IssuesAndFollowupRequired { get; set; }
        public String Attachments { get; set; }
        public String StaffMemberName { get; set; }

        public IFormFile Attach { get; set; }
    }
}
