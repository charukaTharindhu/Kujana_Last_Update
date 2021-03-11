using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_DynamicMenu.Models
{
    public class NewFortnightlySafety
    {
        [Key]
        public int Reference { get; set; }
        public String Unite { get; set; }
        public String Entry_date { get; set; }
        public String Week_ending_date { get; set; }
        public String Test_smoke_detectiors_and_identify_below { get; set; }
        public String How_the_fire_extingusher_and_the_fire_blanket_been_inspected_in_the_last_6_months { get; set; }
        public String Glass_Sprill_management_kits { get; set; }
        public String First_aid_kit_contents_Ckecked { get; set; }
        public String Cylcone_kit_contents_have_been_cheked { get; set; }
        public String Staff { get; set; }

    }
}
