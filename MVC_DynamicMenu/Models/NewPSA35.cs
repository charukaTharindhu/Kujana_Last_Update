using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_DynamicMenu.Models
{
    public class NewPSA35
    {
        [Key]
        public int ClientID { get; set; }
        public String Client_name { get; set; }
        public String Entry_date { get; set; }
        public String Hierarchy { get; set; }
        public String Complains_of_aches_and_pains { get; set; }
        public String Spends_more_time_alone { get; set; }
        public String Tires_easily_has_little_energy { get; set; }
        public String Fidgety_unable_to_sit_still { get; set; }
        public String Has_trouble_with_teacher { get; set; }
        public String Less_interested_in_school { get; set; }
        public String Acts_as_if_driven_by_a_motor { get; set; }
        public String Daydreams_too_much { get; set; }
        public String Distracted_easily { get; set; }
        public String Is_afraid_of_new_situations { get; set; }
        public String Feels_sad_unhappy { get; set; }
        public String Is_irritable_angry { get; set; }
        public String Feels_hopeless { get; set; }
        public String Has_trouble_concentrating { get; set; }
        public String Less_interested_in_friends { get; set; }
        public String Fights_with_other_children { get; set; }
        public String Absent_from_school { get; set; }
        public String School_grades_dropping { get; set; }
        public String Is_down_on_him_or_herself { get; set; }
        public String Has_trouble_sleeping { get; set; }
        public String Worries_a_lot { get; set; }
        public String Wants_to_be_with_you_more_than_before { get; set; }
        public String Feels_he_or_she_is_bad { get; set; }
        public String Takes_unnecessary_risks { get; set; }
        public String Gets_hurt_frequently { get; set; }
        public String Seems_to_be_having_less_fun { get; set; }
        public String Acts_younger_than_children_his_or_her_age { get; set; }
        public String Does_not_listen_to_rules { get; set; }
        public String Does_not_show_feelings { get; set; }
        public String Does_not_understand_feelings_of_other_people { get; set; }
        public String Teases_others { get; set; }
        public String Blames_others_for_his_or_her_troubles { get; set; }
        public String Refuses_to_share { get; set; }

    }
}
