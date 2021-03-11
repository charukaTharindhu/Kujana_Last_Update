using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_DynamicMenu.Models
{
    public class AddNewRestrictivePraticeRecord
    {
        [Key]
        public int ClientID { get; set; }
        public String Client { get; set; }
        public String EntryDate { get; set; }
        public String Hierarchy { get; set; }
        public String NDIS_practice_number { get; set; }
        public String Date_restrictive_practice_used { get; set; }
        public String Time_commenced { get; set; }
        public String Time_ceased { get; set; }
        public String Duration_minutes { get; set; }
        public String What_type_of_restrictive_practice_used { get; set; }
        public String Brief_description_of_the_practice { get; set; }
        public String Routine_or_PRN { get; set; }
        public String Number_of_time_used { get; set; }
        public String Incident_report_refference_number { get; set; }
        public String Circumstances_before_using_restrictive_practice { get; set; }
        public String Related_behaviour_of_Concem { get; set; }
        public String If_other_please_specify { get; set; }
        public String PlaneID { get; set; }
        public String If_no_planeID_select_the_relevent_BSP_status { get; set; }
        public String Authorised_status { get; set; }
        public String Medication { get; set; }
        public String Dosage { get; set; }
        public String Unite_of_Measurment { get; set; }
        public String Frequency { get; set; }
        public String StaffName { get; set; }
        public String Signature { get; set; }
        public String Name { get; set; }
    }
}
