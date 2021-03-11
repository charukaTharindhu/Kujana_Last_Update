using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_DynamicMenu.Models
{
    public class AddNewShiftLogAM
    {
        [Key]
        public int ClientID { get; set; }
        public String Client { get; set; }
        public String EntryDate { get; set; }
        public String Hierarchy { get; set; }
        public String Authorised_substance_use_protocol_adhered_to { get; set; }
        public String Behavior_Emotional_issues { get; set; }
        public String Chore_plane_followed { get; set; }
        public String Daily_planed_adheared_to { get; set; }
        public String Education_has_the_client_Attended_school_today { get; set; }
        public String Excercise_plane_followed { get; set; }
        public String Incident_log_copleted { get; set; }
        public String Medication_Administrated_as_Prescribed { get; set; }
        public String Menu_Diet_plane_folowed { get; set; }
        public String Personal_core_routine_Followed { get; set; }
        public String PRN_administrered { get; set; }
        public String Rainforcement_points_achivevede { get; set; }
        public String Wake_up_routine_followed { get; set; }
        public String Progress_note { get; set; }
        public String Staff_member_name { get; set; }
        
    }
}
