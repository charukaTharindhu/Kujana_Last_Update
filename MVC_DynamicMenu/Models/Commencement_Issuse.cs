using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_DynamicMenu.Models
{
    public class Commencement_Issuse
    {
        [Key]
        public int CommencementID { get; set; }
        public String Program_Details_and_Support_needs { get; set; }
        public String Education_Training { get; set; }
        public String Family_Community_Support { get; set; }
        public String Employeement { get; set; }
        public String Living_Skills { get; set; }
        public String Housing_Accomadation { get; set; }
        public String Aduocacy { get; set; }
        public String anger { get; set; }
        public String Arts_cultural_development { get; set; }
        public String Counselling { get; set; }
        public String Discrimination_including_ { get; set; }
        public String Comments { get; set; }

        public int PatientID { get; set; }
        public Patient Patient { get; set; }

    }
}
