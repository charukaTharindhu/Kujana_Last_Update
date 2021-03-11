using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_DynamicMenu.Models
{
    public class AddNewSupportCoordination
    {
        [Key]
        public int ClientID { get; set; }
        public String Client_name { get; set; }
        public String EntryDate { get; set; }
        public String Heirarchy { get; set; }
        public String Date { get; set; }
        public String Time { get; set; }
        public String Type_of_support_coordination_activity { get; set; }
        public String ContactType { get; set; }
        public String ServiceType { get; set; }
        public String Billable_non_billable_time { get; set; }
        public String Purpose { get; set; }
        public String Outcome { get; set; }
        public String FollowUp { get; set; }
        public String Duration { get; set; }
        public String StaffName { get; set; }
        public String StaffSignature { get; set; }
        public String Name { get; set; }
    }
}
