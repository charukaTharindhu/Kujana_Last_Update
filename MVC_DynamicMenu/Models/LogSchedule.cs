using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_DynamicMenu.Models
{
    public class LogSchedule
    {
        [Key]
        public int Reference { get; set; }
        public String Client_name { get; set; }
        public String Scheduled_start_date { get; set; }
        public String Scheduled_start_time { get; set; }
        public String Scheduled_finish_date { get; set; }
        public String Scheduled_finish_time { get; set; }
        public String Actual_start_date { get; set; }
        public String Actual_start_time { get; set; }
        public String Actual_finish_date { get; set; }
        public String Actual_finish_time { get; set; }
        public String Activity_category { get; set; }
        public String Activity { get; set; }
        public String Persons_attending { get; set; }
        public String Specific_activity_purpose { get; set; }
        public String Describe_outcome { get; set; }
        public String Issues_and_followup_requried { get; set; }
        public String Service_and_billing_note { get; set; }
        public String Staff { get; set; }
        public String Start_time { get; set; }
        public String Finish_time { get; set; }
        public String Service { get; set; }
        public String Service_Provider { get; set; }
        public String Hirarchy_Name { get; set; }
        public String Support_Item { get; set; }
        public String Ratio { get; set; }
        public String Biller_Type { get; set; }
        public String Qty { get; set; }
        public String Unit_Price { get; set; }
        public String Unit { get; set; }

        public int ReferenceID { get; set; }
        public ServiceSchedules ServiceSchedules { get; set; }
    }
}
