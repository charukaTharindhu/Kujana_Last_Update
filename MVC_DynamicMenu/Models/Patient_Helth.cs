using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_DynamicMenu.Models
{
    public class Patient_Helth
    {
        [Key]
        public int PatientHelthID { get; set; } 
        public String Dissabilities_none { get; set; }
        public String Hearing_inmpairment { get; set; }
        public String Vission_impa { get; set; }
        public String Interlrctual_disability { get; set; }
        public String Physical_disability { get; set; }
        public String Acquried_brain_injury { get; set; }
        public String Suspected_ABI { get; set; }
        public String Down_Syndrome { get; set; }
        public String Other { get; set; }
        public String Unknown { get; set; }
        public String Allergies { get; set; }
        public String Skin_condition { get; set; }
        public String Diabetes { get; set; }
        public String Chronic_pain { get; set; }
        public String Epilepsy { get; set; }
        public String Obesity { get; set; }
        public String Infectious_Disease { get; set; }
        public String Repiratory { get; set; }
        public String Cardiovscular { get; set; }
        public String Medicare_number { get; set; }
        public String Suffix { get; set; }
        public String Exp { get; set; }

        public int PatientID { get; set; }
        public Patient Patient { get; set; }
    }
}
