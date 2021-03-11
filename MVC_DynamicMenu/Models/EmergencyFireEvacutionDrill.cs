using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_DynamicMenu.Models
{
    public class EmergencyFireEvacutionDrill
    {
        [Key]
        public int Reference { get; set; }
        public String Unit { get; set; }
        public String Entry_Date { get; set; }
        public String Date { get; set; }
        public String Time { get; set; }
        public String Work_Unit { get; set; }
        public String Location_of_fire { get; set; }
        public String Participants_present_at_the_fire_drill { get; set; }
        public String Describe_the_evacuation { get; set; }
        public String What_worked { get; set; }
        public String Where_any_changes_made_to_how_you_evacute { get; set; }
        public String Where_there_any_risks_identified { get; set; }
        public String Staff_name { get; set; }
        
    }
}
